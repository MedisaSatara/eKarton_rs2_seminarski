using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IPreventivneMjereService
    {
        IEnumerable<Model.Models.PreventivneMjere> Get(MjereSearchRequest request = null);
        Model.Models.PreventivneMjere GetById(int id);
    }
}
