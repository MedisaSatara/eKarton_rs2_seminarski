using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class PacijentOsiguranje
    {
        public int OsiguranjeId { get; set; }
        public int PacijentId { get; set; }
        public DateTime DatumOsiguranja { get; set; }
        public bool Vazece { get; set; }

        public virtual Osiguranje Osiguranje { get; set; }
        public virtual Pacijent Pacijent { get; set; }
    }
}
