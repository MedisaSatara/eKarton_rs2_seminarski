using eKarton.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface INalazService
    {
        IEnumerable<Model.Models.Nalaz> Get(NalazSearchRequest request = null);
        Model.Models.Nalaz GetById(int id);
    }
}
