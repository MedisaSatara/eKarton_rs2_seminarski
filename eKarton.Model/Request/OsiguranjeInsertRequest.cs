using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eKarton.Model.Request
{
    public class OsiguranjeInsertRequest
    {
        public int OsiguranjeId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Osiguranik { get; set; }
    }
}
