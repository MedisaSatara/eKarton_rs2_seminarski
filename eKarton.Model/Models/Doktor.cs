using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Models
{
    public class Doktor
    {

        public int DoktorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public string DatumRodjenja { get; set; }
        public string Grad { get; set; }
        public string Jmbg { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public int OdjelId { get; set; }
        public decimal prosjecnaOcjena { get; set; }

       public virtual Odjel Odjel { get; set; }
        //public virtual ICollection<DodjeljeniDoktor> DodjeljeniDoktors { get; set; }
        //public virtual ICollection<OcjenaDoktora> OcjenaDoktoras { get; set; }
        //public virtual ICollection<Pregled> Pregleds { get; set; }
        //public virtual ICollection<Termin> Termins { get; set; }
    }
}
