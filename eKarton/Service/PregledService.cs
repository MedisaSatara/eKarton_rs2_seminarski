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
    public class PregledService:IPregledService
    {
        private readonly IMapper _mapper;
        private readonly ekartonRContext Context;

        public PregledService(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public IEnumerable<Model.Models.Pregled> Get(PregledSearchRequest request = null)
        {
            var entity = Context.Set<Databases.Pregled>().AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.ImePrezime))
            {
                entity = entity.Where(x => x.Pacijent.Ime.Contains(request.ImePrezime));
            }
            if (request.PacijentId.HasValue)
            {
                entity = entity.Where(x => x.PacijentId == request.PacijentId);
            }
            if (request?.IncludePacijent == true)
            {
                entity = entity.Include(x => x.Pacijent);
            }
            if (request.UputnicaId.HasValue)
            {
                entity = entity.Where(x => x.UputnicaId == request.UputnicaId);
            }
            if (request?.IncludeUputnica == true)
            {
                entity = entity.Include(x => x.Uputnica);
            }
            if (request.TerapijaId.HasValue)
            {
                entity = entity.Where(x => x.TerapijaId == request.TerapijaId);
            }
            if (request?.IncludeTerapija == true)
            {
                entity = entity.Include(x => x.Terapija);
            }
            if (request?.IncludeList?.Length > 0)
            {
                foreach (var item in request.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }

            var list = entity.ToList();
            return _mapper.Map<List<Model.Models.Pregled>>(list);
            //return Context.Pregleds.ToList().Select(x => _mapper.Map<Model.Pregled>(x)).ToList();

        }

        public Model.Models.Pregled GetById(int id)
        {
            var entity = Context.Pregleds.Find(id);

            return _mapper.Map<Model.Models.Pregled>(entity);
        }
    }
}
