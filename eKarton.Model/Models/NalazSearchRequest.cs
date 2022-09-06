using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Models
{
    public class NalazSearchRequest
    {
        public int NalazId { get; set; }
        public int? PacijentId { get; set; }
        public bool? IncludePacijent { get; set; }
        public string ImePrezimePacijenta { get; set; }
        public string[] IncludeList { get; set; }
    }
}
