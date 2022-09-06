using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IOcjenaDoktora
    {
        List<Model.Models.OcjenaDokora> Get(OcjeneSearchRequest search);

        Task<Model.Models.OcjenaDokora> Insert(OcjenaInsertRequest request);
        //public FashionNova.Model.Models.Velicina Update(int id, BojaUpdateRequest request);
    }
}
