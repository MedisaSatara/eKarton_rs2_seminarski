using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Request
{
    public class OcjeneSearchRequest
    {
        public int OcjeneId { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public int DoktorId { get; set; }
        public string[] IncludeList { get; set; }
    }
}
