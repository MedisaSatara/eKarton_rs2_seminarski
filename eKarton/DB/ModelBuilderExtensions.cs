using eKarton.Databases;
using eKarton.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.DB
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<string> Salt = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Salt.Add(KorisnikService.GenerateSalt());
            }

            for (int i = 0; i < 5; i++)
            {
                Salt.Add(PacijentService.GenerateSalt());
            }


            #region Dodavanje Korisnika
            modelBuilder.Entity<Korisnik>().HasData(
                   new Korisnik()
                   {
                       KorisnikId = 1001,
                       Ime = "Arijana",
                       Prezime = "Husic",
                       KorisnickoIme = "admin",
                       LozinkaSalt = Salt[1],
                       LozinkaHash = PacijentService.GenerateHash(Salt[1], "admin")

                   },
                    new Korisnik()
                    {
                        KorisnikId = 1002,
                        Ime = "Medisa",
                        Prezime = "Satara",
                        KorisnickoIme = "korisnik",
                        LozinkaSalt = Salt[2],
                        LozinkaHash = PacijentService.GenerateHash(Salt[2], "korisnik")

                    });
            #endregion

            #region Dodavanje Uloga
            modelBuilder.Entity<Uloga>().HasData(
                 new Uloga()
                 {
                     UlogaId = 1,
                     Naziv = "Admin",
                     OpisUloge = "Upravljanje sistemom"
                 },
                 new Uloga()
                 {
                     UlogaId = 2,
                     Naziv = "Korisnik",
                     OpisUloge = "Pregled podataka"
                 }
                 );
            #endregion

            #region Dodavanje KorisnikUloga
            modelBuilder.Entity<KorisnikUloga>().HasData(
                new KorisnikUloga()
                {
                    KorisnikUlogeId=1,
                    KorisnikId = 1001,
                    UlogaId = 1,
                    DatumIzmjenje = DateTime.Now
                },
                  new KorisnikUloga()
                  {
                      KorisnikUlogeId=2,
                      KorisnikId = 1002,
                      UlogaId = 2,
                      DatumIzmjenje = DateTime.Now
                  });
            #endregion


            #region Podaci Bolnice
            modelBuilder.Entity<Bolnica>().HasData(
                new Bolnica()
                {
                    BolnicaId = 1000,
                    Naziv = "Kantonalna bolnica 'Dr.Safet Mujić'",
                    Adresa = " Maršala Tita 294, Mostar 88000",
                    Email = "bolnica@gmail.com",
                    Telefon = " 036 503-100"
                });
            #endregion

            #region Dodavanje Odjela
            modelBuilder.Entity<Odjel>().HasData(
                new Odjel()
                {
                    OdjelId = 2001,
                    Naziv = "Obiteljska medicina",
                    Telefon = "033/853-222",
                    BolnicaId = 1000

                },
                new Odjel()
                {
                    OdjelId = 2002,
                    Naziv = "Stomatologija",
                    Telefon = "033/853-555",
                    BolnicaId = 1000

                },
                new Odjel()
                {
                    OdjelId = 2003,
                    Naziv = "Neurologija",
                    Telefon = "033/853-552",
                    BolnicaId = 1000

                },
                new Odjel()
                {
                    OdjelId = 2004,
                    Naziv = "Ginekologija",
                    Telefon = "033/853-553",
                    BolnicaId = 1000

                },
                new Odjel()
                {
                    OdjelId = 2005,
                    Naziv = "Psihijatrija",
                    Telefon = "033/853-543",
                    BolnicaId = 1000

                },
                new Odjel()
                {
                    OdjelId = 2006,
                    Naziv = "Pedijatrija",
                    Telefon = "033/853-743",
                    BolnicaId = 1000

                });
            #endregion

            #region Dodavanje Administratora
            modelBuilder.Entity<Administrator>().HasData(
                new Administrator()
                {
                    AdministratorId = 1007,
                    Ime = "Arijana",
                    Prezime = "Husic",
                    DatumRodjenja = "1998/12/16",
                    Telefon = "063 246 022",
                    Email = "arijanahusic@gmail.com",
                    Prebivaliste = "Sarajevo",
                    BolnicaId = 1000
                });
            #endregion

            #region Dodavanje Doktora
            modelBuilder.Entity<Doktor>().HasData(
                new Doktor()
                {
                    DoktorId = 3001,
                    Ime = "STANIJA",
                    Prezime = "TOKMAKČIJA",
                    Spol = "Z",
                    DatumRodjenja = "1998/12/15",
                    Telefon = "063 246 022",
                    Email = "stanija@gmail.com",
                    Grad = "Sarajevo",
                    Jmbg = "1215988789654",
                    OdjelId = 2001
                },
                new Doktor()
                {
                    DoktorId = 3002,
                    Ime = "Rada",
                    Prezime = "Šandrk",
                    Spol = "Z",
                    DatumRodjenja = "1988-01-02",
                    Telefon = "063 246 722",
                    Email = "radas@gmail.com",
                    Grad = "Mostar",
                    Jmbg = "0102988789654",
                    OdjelId = 2006
                },
                new Doktor()
                {
                    DoktorId = 3003,
                    Ime = "Jelena",
                    Prezime = "Pavlovic",
                    Spol = "Z",
                    DatumRodjenja = "1980-10-02",
                    Telefon = "063 216 722",
                    Email = "jelenap@gmail.com",
                    Grad = "Sarajevo",
                    Jmbg = "1002980789654",
                    OdjelId = 2006
                },
                 new Doktor()
                 {
                     DoktorId = 3004,
                     Ime = "Marko",
                     Prezime = "Martinac",
                     Spol = "M",
                     DatumRodjenja = "1975-12-09",
                     Telefon = "063 216 722",
                     Email = "markom@gmail.com",
                     Grad = "Sarajevo",
                     Jmbg = "2099750789654",
                     OdjelId = 2005
                 },
                 new Doktor()
                 {
                     DoktorId = 3005,
                     Ime = "Nada",
                     Prezime = "Bazina",
                     Spol = "Z",
                     DatumRodjenja = "1990 - 07 - 05",
                     Telefon = "062 216 722",
                     Email = "bznada@gmail.com",
                     Grad = "Mostar",
                     Jmbg = "0507990078965",
                     OdjelId = 2005
                 },
                 new Doktor()
                 {
                     DoktorId = 3006,
                     Ime = "Adna",
                     Prezime = "Zalihic",
                     Spol = "Z",
                     DatumRodjenja = "1989 - 06 - 28",
                     Telefon = "061 216 722",
                     Email = "adnaz@gmail.com",
                     Grad = "Mostar",
                     Jmbg = "2806989789654",
                     OdjelId = 2004
                 },
                 new Doktor()
                 {
                     DoktorId = 3007,
                     Ime = "Ranko",
                     Prezime = "Gacic",
                     Spol = "M",
                     DatumRodjenja = "1980 - 02 - 03",
                     Telefon = "062 317 722",
                     Email = "rankog@gmail.com",
                     Grad = "Tuzla",
                     Jmbg = "2039801236547",
                     OdjelId = 2001
                 },
                 new Doktor()
                 {
                     DoktorId = 3008,
                     Ime = "Nikolina",
                     Prezime = "Soce",
                     Spol = "Z",
                     DatumRodjenja = "1970 - 11 - 11",
                     Telefon = "062 216 722",
                     Email = "nikolinas@gmail.com",
                     Grad = "Mostar",
                     Jmbg = "1111197523974",
                     OdjelId = 2001
                 },
                 new Doktor()
                 {
                     DoktorId = 3009,
                     Ime = "Edita",
                     Prezime = "Sopta",
                     Spol = "Z",
                     DatumRodjenja = "1971 - 03 - 22",
                     Telefon = "062 216 722",
                     Email = "editas@gmail.com",
                     Grad = "Stolac",
                     Jmbg = "2203197154239",
                     OdjelId = 2001
                 },
                 new Doktor()
                 {
                     DoktorId = 3010,
                     Ime = "Gordana",
                     Prezime = "Pivic",
                     Spol = "Z",
                     DatumRodjenja = "1971 - 05 - 11",
                     Telefon = "062 216 722",
                     Email = "gordanap@gmail.com",
                     Grad = "Mostar",
                     Jmbg = "1105971289654",
                     OdjelId = 2001
                 },
                 new Doktor()
                 {
                     DoktorId = 3011,
                     Ime = "Senad",
                     Prezime = "Vujica",
                     Spol = "M",
                     DatumRodjenja = "1980 - 11 - 19",
                     Telefon = "062 216 722",
                     Email = "senadv@gmail.com",
                     Grad = "Mostar",
                     Jmbg = "1911980647123",
                     OdjelId = 2002
                 },
                 new Doktor()
                 {
                     DoktorId = 3012,
                     Ime = "Sandra",
                     Prezime = "Brajkovic",
                     Spol = "Z",
                     DatumRodjenja = "1985 - 06 - 22",
                     Telefon = "062 216 722",
                     Email = "sandrab@gmail.com",
                     Grad = "Sarajevo",
                     Jmbg = "2206985452136",
                     OdjelId = 2003
                 });
            #endregion

            #region Dodavanje Osiguranja
            modelBuilder.Entity<Osiguranje>().HasData(
               new Osiguranje()
               {
                   OsiguranjeId = 4001,
                   Osiguranik = "Intera"
               },
               new Osiguranje()
               {
                   OsiguranjeId = 4002,
                   Osiguranik = "Josip 'Biro'"
               },
               new Osiguranje()
               {
                   OsiguranjeId = 4003,
                   Osiguranik = "Hercegovina promet"
               });
            #endregion

            #region Dodavanje OcjenaDoktora
            modelBuilder.Entity<OcjenaDoktora>().HasData(
                new OcjenaDoktora()
                {
                    OcjenaId = 3100,
                    Ocjena = 4,
                    Razlog = "Vrlo dobar",
                    Anonimno = true,
                    DoktorId = 3001
                },
                  new OcjenaDoktora()
                  {
                      OcjenaId = 3200,
                      Ocjena = 5,
                      Razlog = "Odlican",
                      Anonimno = true,
                      DoktorId = 3002
                  },
                  new OcjenaDoktora()
                  {
                      OcjenaId = 3300,
                      Ocjena = 4,
                      Razlog = "Vrlo dobar",
                      Anonimno = true,
                      DoktorId = 3009
                  });
            #endregion

            #region DodavanjePacijenta

            modelBuilder.Entity<Pacijent>().HasData(
                new Pacijent()
                {
                    PacijentId = 5001,
                    Ime = "Josip",
                    Prezime = "Bojcic",
                    Spol = "M",
                    DatumRodjenja = "1998-12-11",
                    Telefon = "061 201 022",
                    MjestoRodjenja = "Mostar",
                    Jmbg = "1211998796541",
                    Prebivaliste = "Mostar",
                    Koagulopatije = false,
                    KrvnaGrupa = "AB",
                    RhFaktor = "+",
                    HronicneBolesti = "Nema",
                    Alergican = "Ne",
                    KorisnickoIme = "pacijent1",
                    LozinkaSalt = Salt[0],
                    LozinkaHash = PacijentService.GenerateHash(Salt[0], "pacijent05"),
                    BrojKartona = "14B579",
                    KorisnikId = 1002
                },
                new Pacijent()
                {
                    PacijentId = 5002,
                    Ime = "Helena",
                    Prezime = "Radic",
                    Spol = "Z",
                    DatumRodjenja = "1980-05-08",
                    Telefon = "062 201 022",
                    MjestoRodjenja = "Mostar",
                    Jmbg = "5089801236547",
                    Prebivaliste = "Mostar",
                    Koagulopatije = false,
                    KrvnaGrupa = "A",
                    RhFaktor = "+",
                    HronicneBolesti = "Nema",
                    Alergican = "Antibiotik",
                    KorisnickoIme = "Pacijent2",
                    BrojKartona = "19378A",
                    LozinkaSalt = Salt[0],
                    LozinkaHash = PacijentService.GenerateHash(Salt[0], "pacijent21"),
                    KorisnikId = 1002
                },
                new Pacijent()
                {
                    PacijentId = 5003,
                    Ime = "Melita",
                    Prezime = "Golubica",
                    Spol = "Z",
                    DatumRodjenja = "1992-11-12",
                    Telefon = "063 991 022",
                    MjestoRodjenja = "Stolac",
                    Jmbg = "5089801236547",
                    Prebivaliste = "Mostar",
                    Koagulopatije = false,
                    KrvnaGrupa = "AB",
                    RhFaktor = "-",
                    HronicneBolesti = "Nema",
                    Alergican = "Ne",
                    KorisnickoIme = "pacijent3",
                    BrojKartona = "8537C",
                    LozinkaSalt = Salt[0],
                    LozinkaHash = PacijentService.GenerateHash(Salt[0], "pacijent45"),
                    KorisnikId = 1002
                });
            #endregion

            #region Dodavanje Dodjeljenog doktora
            modelBuilder.Entity<DodjeljeniDoktor>().HasData(
                new DodjeljeniDoktor()
                {
                    PacijentId = 5001,
                    DoktorId = 3001,
                    DatumOd = DateTime.Now
                },
                new DodjeljeniDoktor()
                {
                    PacijentId = 5002,
                    DoktorId = 3007,
                    DatumOd = DateTime.Now
                },
                new DodjeljeniDoktor()
                {
                    PacijentId = 5003,
                    DoktorId = 3008,
                    DatumOd = DateTime.Now
                });
            #endregion

            #region Dodavanje Osiguranja Pacijenta
            modelBuilder.Entity<PacijentOsiguranje>().HasData(
                new PacijentOsiguranje()
                {
                    PacijentId = 5001,
                    OsiguranjeId = 4001,
                    DatumOsiguranja = DateTime.Now,
                    Vazece = true

                },
                new PacijentOsiguranje()
                {
                    PacijentId = 5002,
                    OsiguranjeId = 4002,
                    DatumOsiguranja = DateTime.Now,
                    Vazece = true
                },
                new PacijentOsiguranje()
                {
                    PacijentId = 5003,
                    OsiguranjeId = 4003,
                    DatumOsiguranja = DateTime.Now,
                    Vazece = true
                });
            #endregion

            #region Dodavanje Terapije
            modelBuilder.Entity<Terapija>().HasData(
                new Terapija()
                {
                    TerapijaId = 6001,
                    NazivLijekova = "Panklav",
                    Uputa = "2 puta na dan",
                    Podsjetnik = "Svako 12 sati",
                    Od = DateTime.Now,
                    Do = DateTime.Now.AddDays(+7)

                });
            #endregion

            #region Dodavanje Uputnica
            modelBuilder.Entity<Uputnica>().HasData(
                new Uputnica()
                {
                    UputnicaId = 6100,
                    Naziv = "Posjeta orl doktora",
                    Datum = DateTime.Now.AddDays(2),
                    Razlog = "Upala uha"
                });
            #endregion

            #region Dodavnje Pregleda
            modelBuilder.Entity<Pregled>().HasData(
                new Pregled()
                {
                    PregledId = 6110,
                    RazlogPosjete = "Bol  uhu i glava",
                    Datum = DateTime.Now,
                    Dijagnoza = "Upala srednjeg uha",
                    TerapijaId = 6001,
                    UputnicaId = 6100,
                    PacijentId = 5001,
                    DoktorId = 3001

                });
            #endregion

            #region Dodavnje Termina
            modelBuilder.Entity<Termin>().HasData(
                new Termin()
                {
                    TerminId = 7110,
                    Razlog = "rutinska kontrola",
                    Datum = DateTime.Now,
                    Vrijeme = "09:15:00",
                    PacijentId = 5001,
                    DoktorId = 3009

                });
            #endregion

            #region Dodavanje Vakcina
            modelBuilder.Entity<Vakcinacija>().HasData(
                new Vakcinacija()
                {
                    VakcinacijaId = 7111,
                    NazivVakcine = "Pfizer"

                });
            #endregion

            #region Dodavanje Vakcinacija
            modelBuilder.Entity<PacijentVakcinacija>().HasData(
                new PacijentVakcinacija()
                {
                    VakcinacijaId = 7111,
                    PacijentId = 5002,
                    Doza = 2,
                    Datum = "2021-12-22",
                    Lokacija = "Mostar"
                });
            #endregion

            #region Dodavanje Nalaza
            modelBuilder.Entity<Nalaz>().HasData(
               new Nalaz()
               {
                   NalazId = 8001,
                   PacijentId = 5001,
                   LicnaAnamneza = "Upala uha",
                   PorodicnaAnamneza = "Nema",
                   RadnaAnamneza = "Nema",
                   Datum = "2021-12-22"
               },
               new Nalaz()
               {
                   NalazId = 8002,
                   PacijentId = 5001,
                   LicnaAnamneza = "Ukljesten vrat",
                   PorodicnaAnamneza = "Nema",
                   RadnaAnamneza = "Nema",
                   Datum = "2021-04-05"
               },
               new Nalaz()
               {
                   NalazId = 8003,
                   PacijentId = 5002,
                   LicnaAnamneza = "Upala pluca",
                   PorodicnaAnamneza = "Secer",
                   RadnaAnamneza = "Nema",
                   Datum = "2022-03-22"
               },
               new Nalaz()
               {
                   NalazId = 8004,
                   PacijentId = 5003,
                   LicnaAnamneza = "Rutinska kontrola",
                   PorodicnaAnamneza = "Nema",
                   RadnaAnamneza = "Nema",
                   Datum = "2022-09-01"
               });
            #endregion

            #region Dodavanje Oboljenja
            modelBuilder.Entity<Oboljenje>().HasData(
               new Oboljenje()
               {
                   OboljenjeId = 8010,
                   Dijagnoza = "Dijabetis",
                   Terapija = "Inzulin"
               },
               new Oboljenje()
               {
                   OboljenjeId = 8020,
                   Dijagnoza = "Astma",
                   Terapija = "Pumpica"
               });
            #endregion

            #region Dodavanje Oboljenja PAcijenta
            modelBuilder.Entity<PacijentOboljenje>().HasData(
               new PacijentOboljenje()
               {
                   OboljenjeId = 8010,
                   PacijentId = 5002,
                   NesposobanZaRad = "Ne",
                   NesposobanZaRadOd = " ",
                   NesposobanZaRadDo = " "
               });
            #endregion

            #region Dodavanje Preventivnih mjera
            modelBuilder.Entity<PreventivneMjere>().HasData(
               new PreventivneMjere()
               {
                   MjereId = 8111,
                   PacijentId = 5003,
                   Stanje = "Alergijska reakcija"
               });
            #endregion

        }

    }
}
