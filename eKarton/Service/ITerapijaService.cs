using eKarton.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface ITerapijaService
    {
        List<Terapija> Get();


        Model.Models.Terapija GetById(int Id);
    }
}
