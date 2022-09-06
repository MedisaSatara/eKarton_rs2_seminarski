using eKarton.Model.Models;
using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IPacijentService
    {
        IEnumerable<eKarton.Model.Models.Pacijent> Get(PacijentSearchRequest search = null);

        Pacijent GetById(int id);

        void Insert(PacijentInsertRequest request);
        void Update(int id, PacijentUpdateRequest request);
        Model.Models.Pacijent Authenticiraj(string username, string pass);
        Task<Model.Models.Pacijent> Login(string username, string password);
    }
}
