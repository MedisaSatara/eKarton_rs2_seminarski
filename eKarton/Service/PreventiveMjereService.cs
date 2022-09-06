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
    public class PreventiveMjereService:IPreventivneMjereService
    {
        private readonly IMapper _mapper;
        private readonly ekartonRContext Context;

        public PreventiveMjereService(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public IEnumerable<Model.Models.PreventivneMjere> Get(MjereSearchRequest request = null)
        {
            var query = Context.PreventivneMjeres.AsQueryable();
            if (request?.IncludePacijent == true)
            {
                query = query.Include(x => x.Pacijent);
            }
            if (request.PacijentId.HasValue)
            {
                query = query.Where(x => x.PacijentId == request.PacijentId);
            }
            if (request.MjereId.HasValue)
            {
                query = query.Where(x => x.MjereId == request.MjereId);
            }
            if (!string.IsNullOrWhiteSpace(request?.ImePacijenta))
            {
                query = query.Where(x => x.Pacijent.Ime == request.ImePacijenta);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.PreventivneMjere>>(list);
            //return Context.PreventivneMjeres.ToList().Select(x => _mapper.Map<Model.PreventivneMjere>(x)).ToList();

        }

        public Model.Models.PreventivneMjere GetById(int id)
        {
            var entity = Context.PreventivneMjeres.Find(id);

            return _mapper.Map<Model.Models.PreventivneMjere>(entity);
        }
    }
}
