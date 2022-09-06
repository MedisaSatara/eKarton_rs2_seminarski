using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Request
{
    public class KorisnikUlogeInsertRequest
    {
        public int KorisniciUlogeId { get; set; }
        public DateTime? DatumIzmjene { get; set; }
        public int KorisniciId { get; set; }
        public int UlogeId { get; set; }
    }
}
