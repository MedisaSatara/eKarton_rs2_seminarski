using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IOsiguranjePacijentService
    {
        public List<Model.Models.PacijentOsiguranje> Get();
        Task<Model.Models.PacijentOsiguranje> Insert(PacijentiOsiguranjeInsertRequest request);
    }
}
