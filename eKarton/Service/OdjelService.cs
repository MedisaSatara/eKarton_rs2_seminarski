using AutoMapper;
using eKarton.Databases;
using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public class OdjelService:IOdjelService
    {
        private readonly IMapper _mapper;
        private readonly ekartonRContext Context;

        public OdjelService(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public IEnumerable<Model.Models.Odjel> Get(OdjelSearchRequest request = null)
        {
            var query = Context.Odjels.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv == request.Naziv);
            }
            var list = query.ToList();
            return _mapper.Map<List<eKarton.Model.Models.Odjel>>(list);
            //return Context.Odjels.ToList().Select(x => _mapper.Map<Model.Odjel>(x)).ToList();

        }

        public Model.Models.Odjel GetById(int id)
        {
            var entity = Context.Odjels.Find(id);

            return _mapper.Map<Model.Models.Odjel>(entity);
        }
        public Model.Models.Odjel Update(int id, OdjelUpdateRequest request)
        {
            var entity = Context.Odjels.Find(id);
            _mapper.Map(request, entity);

            //Context.Korisniks.Attach(entity);
            //Context.Korisniks.Update(entity);
            Context.SaveChanges();
            return _mapper.Map<Model.Models.Odjel>(entity);
        }
        public Model.Models.Odjel Insert(OdjelInsertRequest request)
        {
            var entity = _mapper.Map<Databases.Odjel>(request);
            Context.Add(entity);
            Context.SaveChanges();

            return _mapper.Map<Model.Models.Odjel>(entity);
        }
    }
}
