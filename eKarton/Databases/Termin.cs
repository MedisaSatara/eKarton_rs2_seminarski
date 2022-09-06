using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class Termin
    {
        public int TerminId { get; set; }
        public DateTime Datum { get; set; }
        public string Vrijeme { get; set; }
        public string Razlog { get; set; }
        public int PacijentId { get; set; }
        public int DoktorId { get; set; }

        public virtual Doktor Doktor { get; set; }
        public virtual Pacijent Pacijent { get; set; }
    }
}
