using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IKorisnikUlogeService
    {
        public List<Model.Models.KorisnikUloga> Get();
        Task<Model.Models.KorisnikUloga> Insert(KorisnikUlogeInsertRequest request);
    }
}
