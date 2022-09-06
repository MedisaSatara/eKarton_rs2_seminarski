using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Models
{
    public class Korisnik
    {
        public Korisnik()
        {
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }

        public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; }
        //public virtual ICollection<Pacijent> Pacijents { get; set; }
    }
}
