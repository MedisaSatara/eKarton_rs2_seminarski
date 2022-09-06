using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Models
{
    public class Terapija
    {
        public int TerapijaId { get; set; }
        public string NazivLijekova { get; set; }
        public string Uputa { get; set; }
        public DateTime Od { get; set; }
        public DateTime Do { get; set; }
        public string Podsjetnik { get; set; }

        public virtual ICollection<Pregled> Pregleds { get; set; }
    }
}
