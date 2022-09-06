using AutoMapper;
using eKarton.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public class UlogaService:IUlogaService
    {
        public ekartonRContext Context { get; set; }
        protected readonly IMapper _mapper;

        public UlogaService(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }
        public List<Model.Models.Uloga> Get()
        {
            List<Model.Models.Uloga> result = new List<Model.Models.Uloga>();
            var lista = Context.Ulogas.ToList();

            foreach (var item in lista)
            {
                Model.Models.Uloga uloga = new Model.Models.Uloga();
                uloga.Naziv = item.Naziv;
                uloga.OpisUloge = item.OpisUloge;
                uloga.UlogeId = item.UlogaId;
                result.Add(uloga);
            }
            return result;
        }

        public Model.Models.Uloga ProvjeriAdmin(int UlogaId)
        {
            var lista = Context.Ulogas.ToList();
            Model.Models.Uloga result = new Model.Models.Uloga();

            foreach (var item in lista)
            {
                if (item.UlogaId == UlogaId)
                {
                    if (item.Naziv.Contains("Admin"))
                    {
                        result.Naziv = item.Naziv;
                        result.OpisUloge = item.OpisUloge;
                        result.UlogeId = item.UlogaId;

                        return result;
                    }
                }
            }
            return null;
        }
    }
}
