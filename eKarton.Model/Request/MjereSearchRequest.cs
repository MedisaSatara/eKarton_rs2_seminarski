using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Request
{
    public class MjereSearchRequest
    {
        public string ImePacijenta { get; set; }
        public bool? IncludePacijent { get; set; }
        public int? PacijentId { get; set; }
        public int? MjereId { get; set; }
    }
}
