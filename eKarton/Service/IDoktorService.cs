using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IDoktorService
    {
        IEnumerable<Model.Models.Doktor> Get(DoktorSearchRequest search = null);
        Model.Models.Doktor GetById(int id);
    }
}
