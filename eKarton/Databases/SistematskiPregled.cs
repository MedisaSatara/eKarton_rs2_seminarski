using System;
using System.Collections.Generic;

#nullable disable

namespace eKarton.Databases
{
    public partial class SistematskiPregled
    {
        public int SistematskiPregledId { get; set; }
        public DateTime? Datum { get; set; }
        public decimal? Visina { get; set; }
        public string Tezina { get; set; }
        public string ObimGrudi { get; set; }
        public string ObimStruka { get; set; }
        public decimal? Bmi { get; set; }
        public string KrvniPritisak { get; set; }
        public string Puls { get; set; }
        public string PromjeneNaKozi { get; set; }
        public string Ekstremiteti { get; set; }
        public string Cula { get; set; }
        public string Tonzile { get; set; }
        public string Vrat { get; set; }
        public string GrudniKos { get; set; }
        public string Pluca { get; set; }
        public string Abdomen { get; set; }
        public string KicmeniStub { get; set; }
        public int PacijentId { get; set; }

        public virtual Pacijent Pacijent { get; set; }
    }
}
