using System;
using System.Collections.Generic;
using System.Text;

namespace eKarton.Model.Models
{
    public class Pacijent
    {

        public int PacijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public string DatumRodjenja { get; set; }
        public string Jmbg { get; set; }
        public string MjestoRodjenja { get; set; }
        public string Prebivaliste { get; set; }
        public string Telefon { get; set; }
        public string KrvnaGrupa { get; set; }
        public string RhFaktor { get; set; }
        public string HronicneBolesti { get; set; }
        public string Alergican { get; set; }
        public bool? Koagulopatije { get; set; }
        public string BrojKartona { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }
        public int KorisnikId { get; set; }

        public virtual Korisnik Korisnik { get; set; }
        /*public virtual ICollection<DodjeljeniDoktor> DodjeljeniDoktors { get; set; }
        public virtual ICollection<Nalaz> Nalazs { get; set; }
        public virtual ICollection<PacijentOboljenje> PacijentOboljenjes { get; set; }
        public virtual ICollection<PacijentOsiguranje> PacijentOsiguranjes { get; set; }
        public virtual ICollection<PacijentVakcinacija> PacijentVakcinacijas { get; set; }
        public virtual ICollection<Pregled> Pregleds { get; set; }
        public virtual ICollection<PreventivneMjere> PreventivneMjeres { get; set; }
        public virtual ICollection<SistematskiPregled> SistematskiPregleds { get; set; }
        public virtual ICollection<Termin> Termins { get; set; }*/
    }
}
