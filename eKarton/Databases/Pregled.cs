using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class Pregled
    {
        public int PregledId { get; set; }
        public DateTime Datum { get; set; }
        public string RazlogPosjete { get; set; }
        public string Dijagnoza { get; set; }
        public int TerapijaId { get; set; }
        public int UputnicaId { get; set; }
        public int DoktorId { get; set; }
        public int PacijentId { get; set; }

        public virtual Doktor Doktor { get; set; }
        public virtual Pacijent Pacijent { get; set; }
        public virtual Terapija Terapija { get; set; }
        public virtual Uputnica Uputnica { get; set; }
    }
}
