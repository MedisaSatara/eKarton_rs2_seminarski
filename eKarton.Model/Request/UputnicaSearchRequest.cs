using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Request
{
    public class UputnicaSearchRequest
    {
        public string ImePacijenta { get; set; }
        public int? PacijentId { get; set; }
        public bool? IncludePacijent { get; set; }
        public string[] IncludeList { get; set; }
        public int? UputnicaId { get; set; }
    }
}
