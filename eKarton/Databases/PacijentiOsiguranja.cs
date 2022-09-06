﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Databases
{
    public class PacijentiOsiguranja
    {
        public int PacijentiOsiguranjaId { get; set; }
        public int OsiguranjeId { get; set; }
        public int PacijentId { get; set; }
        public DateTime DatumOsiguranja { get; set; }
        public bool Vazece { get; set; }

        public virtual Osiguranje Osiguranje { get; set; }
        public virtual Pacijent Pacijent { get; set; }
    }
}
