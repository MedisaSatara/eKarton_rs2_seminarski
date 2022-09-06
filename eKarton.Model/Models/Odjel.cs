using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Models
{
    public class Odjel
    {


        public int OdjelId { get; set; }
        public string Naziv { get; set; }
        public string Telefon { get; set; }
        public int BolnicaId { get; set; }

        //public virtual Bolnica Bolnica { get; set; }
        public virtual ICollection<Doktor> Doktors { get; set; }
    }
}
