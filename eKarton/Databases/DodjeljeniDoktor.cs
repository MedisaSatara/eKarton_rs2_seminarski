using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class DodjeljeniDoktor
    {
        public int PacijentId { get; set; }
        public int DoktorId { get; set; }
        public DateTime? DatumOd { get; set; }

        public virtual Doktor Doktor { get; set; }
        public virtual Pacijent Pacijent { get; set; }
    }
}
