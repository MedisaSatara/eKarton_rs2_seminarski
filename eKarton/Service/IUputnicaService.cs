using eKarton.Model.Models;
using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IUputnicaService
    {
        IEnumerable<Model.Models.Uputnica> Get();
        Uputnica GetById(int id);
    }
}
