using AutoMapper;
using eKarton.Databases;
using eKarton.Filters;
using eKarton.Model.Models;
using eKarton.Model.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public class KorisnikService:IKorisnikService
    {
        public ekartonRContext Context { get; set; }
        protected readonly IMapper _mapper;

        public KorisnikService(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public IEnumerable<Model.Models.Korisnik> Get(KorisnikSearchRequest search)
        {
            var query = Context.Korisniks.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().StartsWith(search.Ime.ToLower()));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.Korisnik>>(list);
        }
        public Model.Models.Korisnik GetById(int id)
        {
            var entity = Context.Korisniks.Find(id);
            return _mapper.Map<Model.Models.Korisnik>(entity);
        }
        public void Insert(KorisnikInsertRequest request)
        {
            Databases.Korisnik entity = _mapper.Map<Databases.Korisnik>(request);
            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }
            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            Context.Korisniks.Add(entity);
            Context.SaveChanges();

            foreach (var uloga in request.Uloge)
            {
                Databases.KorisnikUloga korisniciUloge = new Databases.KorisnikUloga();
                korisniciUloge.KorisnikId = entity.KorisnikId;
                korisniciUloge.UlogaId = uloga;
                korisniciUloge.DatumIzmjenje = DateTime.Now;
                Context.KorisnikUlogas.Add(korisniciUloge);
                Context.SaveChanges();
            }
            Context.SaveChanges();
        }

        public void Update(int id, KorisnikUpdateRequest request)
        {
            var entity = Context.Korisniks.Where(x => x.KorisnikId == id).FirstOrDefault();
            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            var ulogeKorisnik = Context.KorisnikUlogas.Where(x => x.KorisnikId == id).ToList();
            foreach (int item in request.Uloge)
            {
                var uloga = Context.Ulogas.Where(x => x.UlogaId == item).FirstOrDefault();
                var imaUlogu = ulogeKorisnik.Where(x => x.KorisnikUlogeId == uloga.UlogaId).FirstOrDefault();

                if (imaUlogu == null)
                {
                    var korisnikUloga = new Databases.KorisnikUloga() { KorisnikId = entity.KorisnikId, UlogaId = uloga.UlogaId, DatumIzmjenje = DateTime.Now };
                    entity.KorisnikUlogas.Add(korisnikUloga);
                }
            }
            Context.Korisniks.Attach(entity);
            Context.Korisniks.Update(entity);
            _mapper.Map(request, entity);
            Context.SaveChanges();
        }

        public async Task<Model.Models.Korisnik> Login(string username, string password)
        {
            var entity = await Context.Korisniks.Include("KorisnikUlogas.Uloga").FirstOrDefaultAsync(x => x.KorisnickoIme == username);
            if (entity == null)
            {
                throw new UserException("Pogrešan username ili password");
            }
            var hash = GenerateHash(entity.LozinkaSalt, password);

            if (hash != entity.LozinkaHash)
            {
                throw new UserException("Pogrešan username ili password");
            }
            return _mapper.Map<Model.Models.Korisnik>(entity);
        }

        public Model.Models.Korisnik Authenticiraj(string username, string pass)
        {
            var user = Context.Korisniks.FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.LozinkaSalt, pass);
                if (hashedPass == user.LozinkaHash)
                {
                    var uloge = Context.KorisnikUlogas.Include(x => x.Uloga).Where(x => x.KorisnikId == user.KorisnikId);
                    Model.Models.Korisnik novikorisnik = new Model.Models.Korisnik();
                    
                    foreach (var item in uloge)
                    {
                        novikorisnik.KorisnikUlogas = new List<Model.Models.KorisnikUloga>();
                        novikorisnik.KorisnikUlogas.Add(new Model.Models.KorisnikUloga
                        {
                            DatumIzmjenje = item.DatumIzmjenje,
                            KorisnikId = item.KorisnikId,
                            UlogaId = item.UlogaId,
                            KorisnikUlogeId = item.KorisnikUlogeId,
                            Uloga = new Model.Models.Uloga
                            {
                                Naziv = item.Uloga.Naziv,
                                OpisUloge = item.Uloga.OpisUloge,
                                UlogeId = item.Uloga.UlogaId
                            }
                        });
                    }
                    novikorisnik.Ime = user.Ime;
                    novikorisnik.Prezime = user.Prezime;
                    novikorisnik.KorisnickoIme = user.KorisnickoIme;
                    novikorisnik.KorisnikId = user.KorisnikId;

                    return novikorisnik;
                }
            }
            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
