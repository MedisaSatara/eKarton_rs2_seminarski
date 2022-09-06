using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class Osiguranje
    {
        public Osiguranje()
        {
            PacijentOsiguranjes = new HashSet<PacijentOsiguranje>();
        }

        public int OsiguranjeId { get; set; }
        public string Osiguranik { get; set; }

        public virtual ICollection<PacijentOsiguranje> PacijentOsiguranjes { get; set; }
    }
}
