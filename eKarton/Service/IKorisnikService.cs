using eKarton.Model.Models;
using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public interface IKorisnikService
    {
        IEnumerable<eKarton.Model.Models.Korisnik> Get(KorisnikSearchRequest search = null);
        Korisnik GetById(int id);
        void Insert(KorisnikInsertRequest request);
        void Update(int id, KorisnikUpdateRequest request);
        Task<Model.Models.Korisnik> Login(string username, string password);
        Korisnik Authenticiraj(string username, string pass);

    }
}
