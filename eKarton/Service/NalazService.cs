using AutoMapper;
using eKarton.Databases;
using eKarton.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public class NalazService:INalazService
    {
        private readonly IMapper _mapper;
        private readonly ekartonRContext Context;

        public NalazService(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public IEnumerable<Model.Models.Nalaz> Get(NalazSearchRequest request = null)
        {
            var query = Context.Nalazs.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.ImePrezimePacijenta))
            {
                query = query.Where(x => x.Pacijent.Ime.Contains(request.ImePrezimePacijenta));
            }
            if (request?.IncludePacijent == true)
            {
                query = query.Include(x => x.Pacijent);
            }
            if (request.PacijentId.HasValue)
            {
                query = query.Where(x => x.PacijentId == request.PacijentId);
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Models.Nalaz>>(list);
            //return Context.Nalazs.ToList().Select(x => _mapper.Map<Model.Nalaz>(x)).ToList();

        }

        public Model.Models.Nalaz GetById(int id)
        {
            var entity = Context.Nalazs.Find(id);
            return _mapper.Map<Model.Models.Nalaz>(entity);
        }
    }
}
