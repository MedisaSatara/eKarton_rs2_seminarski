using AutoMapper;
using eKarton.Databases;
using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public class OsiguranjePacijentService:IOsiguranjePacijentService
    {
        private readonly IMapper _mapper;
        private readonly ekartonRContext Context;

        public OsiguranjePacijentService(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public List<Model.Models.PacijentOsiguranje> Get()
        {
            var query = Context.PacijentOsiguranjes.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.PacijentOsiguranje>>(list);
        }
        public async Task<Model.Models.PacijentOsiguranje> Insert(PacijentiOsiguranjeInsertRequest request)
        {
            Databases.PacijentOsiguranje entity = _mapper.Map<Databases.PacijentOsiguranje>(request);
            await Context.PacijentOsiguranjes.AddAsync(entity);
            await Context.SaveChangesAsync();
            return _mapper.Map<Model.Models.PacijentOsiguranje>(entity);
        }
    }
}
