using AutoMapper;
using eKarton.Databases;
using eKarton.Model.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public class DoktorService:IDoktorService
    {
        private readonly IMapper _mapper;
        private readonly ekartonRContext Context;

        public DoktorService(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public IEnumerable<Model.Models.Doktor> Get(DoktorSearchRequest request = null)
        {
            var query = Context.Doktors.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.ImePrezime))
            {
                query = query.Where(x => x.Ime == request.ImePrezime);
            }
            if (!string.IsNullOrWhiteSpace(request?.NazivOdjela))
            {
                query = query.Where(x => x.Odjel.Naziv.Contains(request.NazivOdjela));
            }

            if (request.OdjelId.HasValue)
            {
                query = query.Where(x => x.OdjelId == request.OdjelId);
            }
            if (request?.IncludeOdjel == true)
            {
                query = query.Include(x => x.Odjel);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.Doktor>>(list);
            //return Context.Doktors.ToList().Select(x => _mapper.Map<Model.Doktor>(x)).ToList();

        }

        public Model.Models.Doktor GetById(int id)
        {
            var entity = Context.Doktors.Find(id);

            return _mapper.Map<Model.Models.Doktor>(entity);
        }
    }
}
