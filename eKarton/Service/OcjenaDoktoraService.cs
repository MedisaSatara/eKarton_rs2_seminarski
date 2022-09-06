using AutoMapper;
using eKarton.Databases;
using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public class OcjenaDoktoraService:IOcjenaDoktora
    {
        private readonly ekartonRContext Context;
        private readonly IMapper _mapper;

        public OcjenaDoktoraService(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public List<Model.Models.OcjenaDokora> Get(OcjeneSearchRequest search)
        {
            var query = Context.OcjenaDoktoras.AsQueryable();
            if ((!string.IsNullOrWhiteSpace((search?.DoktorId).ToString())) && search?.DoktorId != 0)
            {
                query = query.Where(x => x.DoktorId == search.DoktorId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Models.OcjenaDokora>>(list);
        }
        public async Task<Model.Models.OcjenaDokora> Insert(OcjenaInsertRequest request)
        {
            Databases.OcjenaDoktora entity = _mapper.Map<Databases.OcjenaDoktora>(request);

            await Context.OcjenaDoktoras.AddAsync(entity);
            await Context.SaveChangesAsync();
            return _mapper.Map<Model.Models.OcjenaDokora>(entity);
        }
        //public FashionNova.Model.Models.Velicina Update(int id, BojaUpdateRequest request)
        //{
        //    var entity = _context.Boja.Find(id);
        //    _mapper.Map(request, entity);

        //    _context.SaveChanges();
        //    return _mapper.Map<Model.Models.Boja>(entity);
        //}
    }
}
