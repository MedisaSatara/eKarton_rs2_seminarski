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
    public class UputnicaService:IUputnicaService
    {
        private readonly IMapper _mapper;
        private readonly ekartonRContext Context;

        public UputnicaService(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public IEnumerable<Model.Models.Uputnica> Get()
        {
            /*var query = Context.Uputnicas.AsQueryable();
            if (request.UputnicaId.HasValue)
            {
                query = query.Where(x => x.UputnicaId == request.UputnicaId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.Uputnica>>(list);*/
            return Context.Uputnicas.ToList().Select(x => _mapper.Map<Model.Models.Uputnica>(x)).ToList();

        }

        public Model.Models.Uputnica GetById(int id)
        {
            var entity = Context.Uputnicas.Find(id);

            return _mapper.Map<Model.Models.Uputnica>(entity);
        }
    }
}
