using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class Uputnica
    {
        public Uputnica()
        {
            Pregleds = new HashSet<Pregled>();
        }

        public int UputnicaId { get; set; }
        public string Naziv { get; set; }
        public DateTime Datum { get; set; }
        public string Razlog { get; set; }

        public virtual ICollection<Pregled> Pregleds { get; set; }
    }
}
