using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Models
{
    public class OcjenaDokora
    {
        public int OcjenaId { get; set; }
        public int Ocjena { get; set; }
        public string Razlog { get; set; }
        public bool? Anonimno { get; set; }
        public int DoktorId { get; set; }

        public virtual Doktor Doktor { get; set; }
    }
}
