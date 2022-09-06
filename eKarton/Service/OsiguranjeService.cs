using AutoMapper;
using eKarton.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public class OsiguranjeService:IOsiguranjeService
    {
        private readonly IMapper _mapper;
        private readonly ekartonRContext Context;

        public OsiguranjeService(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        /*public IEnumerable<Model.Models.Osiguranje> Get()
        {
            
            //var list = query.ToList();
            //return _mapper.Map<List<Model.Models.Doktor>>(list);
            return Context.Osiguranjes.ToList().Select(x => _mapper.Map<Model.Models.Osiguranje>(x)).ToList();

        }*/
        public List<Model.Models.Osiguranje>Get()
        {
            List<Model.Models.Osiguranje> result = new List<Model.Models.Osiguranje>();
            var lista = Context.Osiguranjes.ToList();

            foreach(var item in lista)
            {
                Model.Models.Osiguranje osiguranje = new Model.Models.Osiguranje();
                osiguranje.OsiguranjeId = item.OsiguranjeId;
                osiguranje.Osiguranik = item.Osiguranik;
                result.Add(osiguranje);
            }
            return result;
        }

        public Model.Models.Osiguranje GetById(int id)
        {
            var entity = Context.Osiguranjes.Find(id);
            return _mapper.Map<Model.Models.Osiguranje>(entity);
        }
        public Model.Models.Osiguranje ProvjeriOsiguranje(int OsiguranjeId)
        {
            var lista = Context.Osiguranjes.ToList();
            Model.Models.Osiguranje result = new Model.Models.Osiguranje();

            foreach (var item in lista)
            {
                if (item.OsiguranjeId == OsiguranjeId)
                {
                    if (item.Osiguranik.Any())
                    {
                        result.Osiguranik = item.Osiguranik;
                        result.OsiguranjeId = item.OsiguranjeId;
                        return result;
                    }
                }
            }
            return null;
        }
    }
}
