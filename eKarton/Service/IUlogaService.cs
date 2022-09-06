using eKarton.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IUlogaService
    {
        List<Model.Models.Uloga> Get();
        Uloga ProvjeriAdmin(int UlogaId);
    }
}
