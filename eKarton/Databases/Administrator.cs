using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class Administrator
    {
        public int AdministratorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string DatumRodjenja { get; set; }
        public string Prebivaliste { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int BolnicaId { get; set; }

        public virtual Bolnica Bolnica { get; set; }
    }
}
