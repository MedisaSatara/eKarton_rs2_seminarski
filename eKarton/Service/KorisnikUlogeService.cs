using AutoMapper;
using eKarton.Databases;
using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public class KorisnikUlogeService:IKorisnikUlogeService
    {
        public ekartonRContext Context { get; set; }
        protected readonly IMapper _mapper;

        public KorisnikUlogeService(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public List<Model.Models.KorisnikUloga> Get()
        {
            var query = Context.KorisnikUlogas.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.KorisnikUloga>>(list);
        }
        public async Task<Model.Models.KorisnikUloga> Insert(KorisnikUlogeInsertRequest request)
        {
            Databases.KorisnikUloga entity = _mapper.Map<Databases.KorisnikUloga>(request);
            await Context.KorisnikUlogas.AddAsync(entity);
            await Context.SaveChangesAsync();
            return _mapper.Map<Model.Models.KorisnikUloga>(entity);
        }
    }
}
