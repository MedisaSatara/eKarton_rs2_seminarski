using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class Odjel
    {
        public Odjel()
        {
            Doktors = new HashSet<Doktor>();
        }

        public int OdjelId { get; set; }
        public string Naziv { get; set; }
        public string Telefon { get; set; }
        public int BolnicaId { get; set; }

        public virtual Bolnica Bolnica { get; set; }
        public virtual ICollection<Doktor> Doktors { get; set; }
    }
}
