using AutoMapper;
using eKarton.Databases;
using eKarton.Filters;
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
    public class PacijentService:IPacijentService
    {
        public ekartonRContext Context { get; set; }
        protected readonly IMapper _mapper;

        public PacijentService(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public IEnumerable<Model.Models.Pacijent> Get(PacijentSearchRequest search=null)
        {
            var query = Context.Pacijents.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().StartsWith(search.Ime.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.ToLower().StartsWith(search.Prezime.ToLower()));
            }

            //if (search?.IsUlogeLoadingEnabled == true)
            //{
            //    query = query.Include(x => x.KorisniciUloge);
            //}

            var list = query.ToList();
            return _mapper.Map<List<Model.Models.Pacijent>>(list);
        }

        public Model.Models.Pacijent GetById(int id)
        {
            var entity = Context.Pacijents.Find(id);

            return _mapper.Map<Model.Models.Pacijent>(entity);

        }
        public void Insert(PacijentInsertRequest request)
        {
           Databases.Pacijent entity = _mapper.Map<Databases.Pacijent>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            Context.Pacijents.Add(entity);
            Context.SaveChanges();
        }
        
        public void Update(int id, PacijentUpdateRequest request)
        {
            var entity = Context.Pacijents.Where(x => x.PacijentId == id).FirstOrDefault();
            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }
            Context.Pacijents.Attach(entity);
            Context.Pacijents.Update(entity);
            _mapper.Map(request, entity);

            Context.SaveChanges();
        }
        public async Task<Model.Models.Pacijent> Login(string username, string password)
        {
            var entity = await Context.Korisniks.Include("PacijentUloga.Uloga").FirstOrDefaultAsync(x => x.KorisnickoIme == username);

            if (entity == null)
            {
                throw new UserException("Pogresan username ili password");
            }

            var hash = GenerateHash(entity.LozinkaSalt, password);

            if (hash != entity.LozinkaHash)
            {
                throw new UserException("Pogresan username ili password");
            }
            return _mapper.Map<Model.Models.Pacijent>(entity);
        }

        public Model.Models.Pacijent Authenticiraj(string username, string pass)
        {
            var user = Context.Pacijents.FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.LozinkaSalt, pass);

                if (hashedPass == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Models.Pacijent>(user);
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
