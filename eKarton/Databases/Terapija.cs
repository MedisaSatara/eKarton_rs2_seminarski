using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class Terapija
    {
        public Terapija()
        {
            Pregleds = new HashSet<Pregled>();
        }

        public int TerapijaId { get; set; }
        public string NazivLijekova { get; set; }
        public string Uputa { get; set; }
        public DateTime Od { get; set; }
        public DateTime Do { get; set; }
        public string Podsjetnik { get; set; }

        public virtual ICollection<Pregled> Pregleds { get; set; }
    }
}
