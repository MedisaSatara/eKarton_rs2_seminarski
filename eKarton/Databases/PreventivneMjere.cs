using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class PreventivneMjere
    {
        public int MjereId { get; set; }
        public string Stanje { get; set; }
        public int PacijentId { get; set; }

        public virtual Pacijent Pacijent { get; set; }
    }
}
