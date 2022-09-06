using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Request
{
    public class PacijentiOsiguranjeInsertRequest
    {
        public int OsiguranjeId { get; set; }
        public int PacijentId { get; set; }
        public DateTime DatumOsiguranja { get; set; }
        public bool Vazece { get; set; }
    }
}
