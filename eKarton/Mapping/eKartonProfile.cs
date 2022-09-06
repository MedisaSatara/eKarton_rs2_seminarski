using AutoMapper;
using eKarton.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Mapping
{
    public class eKartonProfile:Profile
    {
        public eKartonProfile()
        {
            CreateMap<Databases.Korisnik, Model.Models.Korisnik>();
            CreateMap<Databases.Pacijent, Model.Models.Pacijent>();
            CreateMap<Databases.KorisnikUloga, Model.Models.KorisnikUloga>();
            CreateMap<Databases.Doktor, Model.Models.Doktor>();
            CreateMap<Databases.Uloga, Model.Models.Uloga>();
            CreateMap<Databases.Odjel, Model.Models.Odjel>();
            CreateMap<Databases.Osiguranje, Model.Models.Osiguranje>();
            CreateMap<Databases.PacijentOsiguranje, Model.Models.PacijentOsiguranje>();
            CreateMap<Databases.Pregled, Model.Models.Pregled>();
            CreateMap<Databases.Terapija, Model.Models.Terapija>();
            CreateMap<Databases.PreventivneMjere, Model.Models.PreventivneMjere>();
            CreateMap<Databases.Uputnica, Model.Models.Uputnica>();
            CreateMap<Databases.Uputnica, Model.Models.Uputnica>();
            CreateMap<Databases.OcjenaDoktora, Model.Models.OcjenaDokora>();


            CreateMap<KorisnikUpdateRequest, Databases.Korisnik>();
            CreateMap<KorisnikSearchRequest, Databases.Korisnik>();

            CreateMap<OdjelSearchRequest, Databases.Odjel>();
            CreateMap<OdjelUpdateRequest, Databases.Odjel>();
            CreateMap<OdjelInsertRequest, Databases.Odjel>();

            CreateMap<PregledSearchRequest, Databases.Pregled>();
            CreateMap<UputnicaSearchRequest, Databases.Uputnica>();

            CreateMap<DoktorSearchRequest, Databases.Doktor>();

            CreateMap<PacijentSearchRequest, Databases.Pacijent>();
            CreateMap<PacijentUpdateRequest, Databases.Pacijent>();

            CreateMap<MjereSearchRequest, Databases.PreventivneMjere>();
            CreateMap<OcjeneSearchRequest, Databases.OcjenaDoktora>();
            CreateMap<OcjenaInsertRequest, Databases.OcjenaDoktora>();
















        }
    }
}
