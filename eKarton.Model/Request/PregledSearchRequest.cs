using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Request
{
    public class PregledSearchRequest
    {
        public string ImePrezime { get; set; }
        public int? PacijentId { get; set; }
        public bool? IncludePacijent { get; set; }
        public int? UputnicaId { get; set; }
        public bool? IncludeUputnica { get; set; }
        public string[] IncludeList { get; set; }
        public int? TerapijaId { get; set; }
        public bool? IncludeTerapija { get; set; }
    }
}
