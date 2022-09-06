using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IOsiguranjeService
    {
        //IEnumerable<Model.Models.Osiguranje> Get();
        List<Model.Models.Osiguranje> Get();
       Model.Models.Osiguranje GetById(int id);
        Model.Models.Osiguranje ProvjeriOsiguranje(int OsiguranjeId);


    }
}
