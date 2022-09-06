using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Models
{
    public class KorisnikUloga
    {
        public int KorisnikUlogeId { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }
        public DateTime? DatumIzmjenje { get; set; }

        //public virtual Korisnik Korisnik { get; set; }
        public virtual Uloga Uloga { get; set; }
    }
}
