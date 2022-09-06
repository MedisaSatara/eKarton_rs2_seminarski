using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IOdjelService
    {
        IEnumerable<Model.Models.Odjel> Get(OdjelSearchRequest request = null);
        Model.Models.Odjel GetById(int id);
        Model.Models.Odjel Update(int id, OdjelUpdateRequest request);
        Model.Models.Odjel Insert(OdjelInsertRequest request);
    }
}
