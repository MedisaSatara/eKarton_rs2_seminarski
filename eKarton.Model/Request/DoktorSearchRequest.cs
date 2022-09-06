using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Request
{
    public class DoktorSearchRequest
    {
        public string ImePrezime { get; set; }
        public int? OdjelId { get; set; }
        public bool? IncludeOdjel { get; set; }
        public string NazivOdjela { get; set; }

    }
}
