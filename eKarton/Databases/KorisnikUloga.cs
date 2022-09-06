using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class KorisnikUloga
    {
        public int KorisnikUlogeId { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }
        public DateTime? DatumIzmjenje { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        public virtual Uloga Uloga { get; set; }
    }
}
