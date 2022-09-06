using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class OcjenaDoktora
    {
        public int OcjenaId { get; set; }
        public int Ocjena { get; set; }
        public string Razlog { get; set; }
        public bool? Anonimno { get; set; }
        public int DoktorId { get; set; }

        public virtual Doktor Doktor { get; set; }
    }
}
