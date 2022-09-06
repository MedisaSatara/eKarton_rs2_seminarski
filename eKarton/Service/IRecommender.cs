using eKarton.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IRecommender
    {
        List<Doktor> GetSlicneDoktore(int doktorId);

    }
}
