using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Models
{
    public class Uputnica
    {

        public int UputnicaId { get; set; }
        public string Naziv { get; set; }
        public DateTime Datum { get; set; }
        public string Razlog { get; set; }

        public virtual ICollection<Pregled> Pregleds { get; set; }
    }
}
