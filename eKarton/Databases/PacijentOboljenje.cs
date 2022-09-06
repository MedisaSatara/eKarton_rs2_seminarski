using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class PacijentOboljenje
    {
        public int OboljenjeId { get; set; }
        public int PacijentId { get; set; }
        public string NesposobanZaRad { get; set; }
        public string NesposobanZaRadOd { get; set; }
        public string NesposobanZaRadDo { get; set; }

        public virtual Oboljenje Oboljenje { get; set; }
        public virtual Pacijent Pacijent { get; set; }
    }
}
