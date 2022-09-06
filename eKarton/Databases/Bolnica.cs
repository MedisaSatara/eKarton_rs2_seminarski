using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class Bolnica
    {
        public Bolnica()
        {
            Administrators = new HashSet<Administrator>();
            Odjels = new HashSet<Odjel>();
        }

        public int BolnicaId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Administrator> Administrators { get; set; }
        public virtual ICollection<Odjel> Odjels { get; set; }
    }
}
