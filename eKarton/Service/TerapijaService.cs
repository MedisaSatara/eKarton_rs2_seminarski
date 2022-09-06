using AutoMapper;
using eKarton.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public class TerapijaService:ITerapijaService
    {
        private readonly IMapper _mapper;
        private readonly ekartonRContext Context;

        public TerapijaService(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public List<Model.Models.Terapija> Get()
        {
            /*var query = Context.Pregleds.AsQueryable();
            if(!string.IsNullOrWhiteSpace(request?.ImePrezime))
            {
                query = query.Where(x => x.Pacijent.Ime == request.ImePrezime);
            }
            if(request.TerapijaId.HasValue)
            {
                query = query.Where(x => x.TerapijaId == request.TerapijaId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Terapija>>(list);*/

            return Context.Terapijas.ToList().Select(x => _mapper.Map<Model.Models.Terapija>(x)).ToList();

        }

        public Model.Models.Terapija GetById(int id)
        {
            var entity = Context.Terapijas.Find(id);

            return _mapper.Map<Model.Models.Terapija>(entity);
        }
    }
}
