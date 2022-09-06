using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eKarton.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolnica",
                columns: table => new
                {
                    BolnicaId = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolnica", x => x.BolnicaId);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LozinkaHash = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikId);
                });

            migrationBuilder.CreateTable(
                name: "Oboljenje",
                columns: table => new
                {
                    OboljenjeId = table.Column<int>(type: "int", nullable: false),
                    Dijagnoza = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Terapija = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oboljenje", x => x.OboljenjeId);
                });

            migrationBuilder.CreateTable(
                name: "Osiguranje",
                columns: table => new
                {
                    OsiguranjeId = table.Column<int>(type: "int", nullable: false),
                    Osiguranik = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osiguranje", x => x.OsiguranjeId);
                });

            migrationBuilder.CreateTable(
                name: "Terapija",
                columns: table => new
                {
                    TerapijaId = table.Column<int>(type: "int", nullable: false),
                    NazivLijekova = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Uputa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OD = table.Column<DateTime>(type: "date", nullable: false),
                    DO = table.Column<DateTime>(type: "date", nullable: false),
                    Podsjetnik = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terapija", x => x.TerapijaId);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    UlogaId = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    OpisUloge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "Uputnica",
                columns: table => new
                {
                    UputnicaId = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Datum = table.Column<DateTime>(type: "date", nullable: false),
                    Razlog = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uputnica", x => x.UputnicaId);
                });

            migrationBuilder.CreateTable(
                name: "Vakcinacija",
                columns: table => new
                {
                    VakcinacijaId = table.Column<int>(type: "int", nullable: false),
                    NazivVakcine = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vakcinacija", x => x.VakcinacijaId);
                });

            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    AdministratorId = table.Column<int>(type: "int", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DatumRodjenja = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Prebivaliste = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BolnicaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.AdministratorId);
                    table.ForeignKey(
                        name: "FK_AdministratorBolnica",
                        column: x => x.BolnicaId,
                        principalTable: "Bolnica",
                        principalColumn: "BolnicaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Odjel",
                columns: table => new
                {
                    OdjelId = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BolnicaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odjel", x => x.OdjelId);
                    table.ForeignKey(
                        name: "FK_OdjelBolnica",
                        column: x => x.BolnicaId,
                        principalTable: "Bolnica",
                        principalColumn: "BolnicaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pacijent",
                columns: table => new
                {
                    PacijentId = table.Column<int>(type: "int", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Spol = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DatumRodjenja = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    JMBG = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    MjestoRodjenja = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Prebivaliste = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    KrvnaGrupa = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    RhFaktor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HronicneBolesti = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Alergican = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Koagulopatije = table.Column<bool>(type: "bit", nullable: true),
                    BrojKartona = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LozinkaHash = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacijent", x => x.PacijentId);
                    table.ForeignKey(
                        name: "FK_PacijentKorisnik",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikUloga",
                columns: table => new
                {
                    KorisnikUlogeId = table.Column<int>(type: "int", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    UlogaId = table.Column<int>(type: "int", nullable: false),
                    DatumIzmjenje = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikUloge", x => x.KorisnikUlogeId);
                    table.ForeignKey(
                        name: "FK_KorisnikUloga",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UlogaKorisnik",
                        column: x => x.UlogaId,
                        principalTable: "Uloga",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doktor",
                columns: table => new
                {
                    DoktorId = table.Column<int>(type: "int", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Spol = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    DatumRodjenja = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Grad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    JMBG = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OdjelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktor", x => x.DoktorId);
                    table.ForeignKey(
                        name: "FK_OdjelDoktor",
                        column: x => x.OdjelId,
                        principalTable: "Odjel",
                        principalColumn: "OdjelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nalaz",
                columns: table => new
                {
                    NalazId = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LicnaAnamneza = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RadnaAnamneza = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PorodicnaAnamneza = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PacijentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nalaz", x => x.NalazId);
                    table.ForeignKey(
                        name: "FK_NalazPacijent",
                        column: x => x.PacijentId,
                        principalTable: "Pacijent",
                        principalColumn: "PacijentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PacijentOboljenje",
                columns: table => new
                {
                    OboljenjeId = table.Column<int>(type: "int", nullable: false),
                    PacijentId = table.Column<int>(type: "int", nullable: false),
                    NesposobanZaRad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NesposobanZaRadOd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NesposobanZaRadDo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacijentOboljenje", x => new { x.OboljenjeId, x.PacijentId });
                    table.ForeignKey(
                        name: "FK__PacijentO__Obolj__60A75C0F",
                        column: x => x.OboljenjeId,
                        principalTable: "Oboljenje",
                        principalColumn: "OboljenjeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__PacijentO__Pacij__619B8048",
                        column: x => x.PacijentId,
                        principalTable: "Pacijent",
                        principalColumn: "PacijentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PacijentOsiguranje",
                columns: table => new
                {
                    OsiguranjeId = table.Column<int>(type: "int", nullable: false),
                    PacijentId = table.Column<int>(type: "int", nullable: false),
                    DatumOsiguranja = table.Column<DateTime>(type: "date", nullable: false),
                    Vazece = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FK_PacijentOsiguranje", x => new { x.OsiguranjeId, x.PacijentId });
                    table.ForeignKey(
                        name: "FK__PacijentO__Osigu__4222D4EF",
                        column: x => x.OsiguranjeId,
                        principalTable: "Osiguranje",
                        principalColumn: "OsiguranjeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__PacijentO__Pacij__4316F928",
                        column: x => x.PacijentId,
                        principalTable: "Pacijent",
                        principalColumn: "PacijentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PacijentVakcinacija",
                columns: table => new
                {
                    VakcinacijaId = table.Column<int>(type: "int", nullable: false),
                    PacijentId = table.Column<int>(type: "int", nullable: false),
                    Doza = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Lokacija = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FK_PacijentVakcinacija", x => new { x.VakcinacijaId, x.PacijentId });
                    table.ForeignKey(
                        name: "FK__PacijentV__Pacij__59063A47",
                        column: x => x.PacijentId,
                        principalTable: "Pacijent",
                        principalColumn: "PacijentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__PacijentV__Vakci__5812160E",
                        column: x => x.VakcinacijaId,
                        principalTable: "Vakcinacija",
                        principalColumn: "VakcinacijaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreventivneMjere",
                columns: table => new
                {
                    MjereId = table.Column<int>(type: "int", nullable: false),
                    Stanje = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PacijentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mjere", x => x.MjereId);
                    table.ForeignKey(
                        name: "FK_PreventivneMjerePacijent",
                        column: x => x.PacijentId,
                        principalTable: "Pacijent",
                        principalColumn: "PacijentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SistematskiPregled",
                columns: table => new
                {
                    SistematskiPregledId = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "date", nullable: true),
                    Visina = table.Column<decimal>(type: "decimal(10,0)", nullable: true),
                    Tezina = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ObimGrudi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ObimStruka = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BMI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    KrvniPritisak = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Puls = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PromjeneNaKozi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ekstremiteti = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Cula = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tonzile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Vrat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GrudniKos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Pluca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Abdomen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KicmeniStub = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PacijentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistematskiPregled", x => x.SistematskiPregledId);
                    table.ForeignKey(
                        name: "FK_SistematskiPRegledPacijent",
                        column: x => x.PacijentId,
                        principalTable: "Pacijent",
                        principalColumn: "PacijentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DodjeljeniDoktor",
                columns: table => new
                {
                    PacijentId = table.Column<int>(type: "int", nullable: false),
                    DoktorId = table.Column<int>(type: "int", nullable: false),
                    DatumOd = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DodjeljeniDoktor", x => new { x.PacijentId, x.DoktorId });
                    table.ForeignKey(
                        name: "FK__Dodjeljen__Dokto__3F466844",
                        column: x => x.DoktorId,
                        principalTable: "Doktor",
                        principalColumn: "DoktorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Dodjeljen__Pacij__3E52440B",
                        column: x => x.PacijentId,
                        principalTable: "Pacijent",
                        principalColumn: "PacijentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OcjenaDoktora",
                columns: table => new
                {
                    OcjenaId = table.Column<int>(type: "int", nullable: false),
                    Ocjena = table.Column<int>(type: "int", nullable: false),
                    Razlog = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Anonimno = table.Column<bool>(type: "bit", nullable: true),
                    DoktorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjena", x => x.OcjenaId);
                    table.ForeignKey(
                        name: "FK_OcjenaDoktora",
                        column: x => x.DoktorId,
                        principalTable: "Doktor",
                        principalColumn: "DoktorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pregled",
                columns: table => new
                {
                    PregledId = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "date", nullable: false),
                    RazlogPosjete = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Dijagnoza = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TerapijaId = table.Column<int>(type: "int", nullable: false),
                    UputnicaId = table.Column<int>(type: "int", nullable: false),
                    DoktorId = table.Column<int>(type: "int", nullable: false),
                    PacijentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pregled", x => x.PregledId);
                    table.ForeignKey(
                        name: "FK_PregledDoktor",
                        column: x => x.DoktorId,
                        principalTable: "Doktor",
                        principalColumn: "DoktorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PregledPacijent",
                        column: x => x.PacijentId,
                        principalTable: "Pacijent",
                        principalColumn: "PacijentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PregledTerapija",
                        column: x => x.TerapijaId,
                        principalTable: "Terapija",
                        principalColumn: "TerapijaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PregledUputnica",
                        column: x => x.UputnicaId,
                        principalTable: "Uputnica",
                        principalColumn: "UputnicaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Termin",
                columns: table => new
                {
                    TerminId = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "date", nullable: false),
                    Vrijeme = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Razlog = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PacijentId = table.Column<int>(type: "int", nullable: false),
                    DoktorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termin", x => x.TerminId);
                    table.ForeignKey(
                        name: "FK_TerminDoktor",
                        column: x => x.DoktorId,
                        principalTable: "Doktor",
                        principalColumn: "DoktorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TerminPacijent",
                        column: x => x.PacijentId,
                        principalTable: "Pacijent",
                        principalColumn: "PacijentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Bolnica",
                columns: new[] { "BolnicaId", "Adresa", "Email", "Naziv", "Telefon" },
                values: new object[] { 1000, " Maršala Tita 294, Mostar 88000", "bolnica@gmail.com", "Kantonalna bolnica 'Dr.Safet Mujić'", " 036 503-100" });

            migrationBuilder.InsertData(
                table: "Korisnik",
                columns: new[] { "KorisnikId", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime" },
                values: new object[,]
                {
                    { 1001, "Arijana", "admin", "1Ikzb+4T3m/mSsSAR/nHhHf76fg=", "IPO1Gbirb4VplijalXCMJA==", "Husic" },
                    { 1002, "Medisa", "korisnik", "tYVhM9e1TpmlQVGMlm9/Q3tkeEQ=", "RH0O7zwBCMV4DgpZNcdDQQ==", "Satara" }
                });

            migrationBuilder.InsertData(
                table: "Oboljenje",
                columns: new[] { "OboljenjeId", "Dijagnoza", "Terapija" },
                values: new object[,]
                {
                    { 8010, "Dijabetis", "Inzulin" },
                    { 8020, "Astma", "Pumpica" }
                });

            migrationBuilder.InsertData(
                table: "Osiguranje",
                columns: new[] { "OsiguranjeId", "Osiguranik" },
                values: new object[,]
                {
                    { 4001, "Intera" },
                    { 4002, "Josip 'Biro'" },
                    { 4003, "Hercegovina promet" }
                });

            migrationBuilder.InsertData(
                table: "Terapija",
                columns: new[] { "TerapijaId", "DO", "NazivLijekova", "OD", "Podsjetnik", "Uputa" },
                values: new object[] { 6001, new DateTime(2022, 9, 9, 11, 13, 54, 179, DateTimeKind.Local).AddTicks(8403), "Panklav", new DateTime(2022, 9, 2, 11, 13, 54, 179, DateTimeKind.Local).AddTicks(7446), "Svako 12 sati", "2 puta na dan" });

            migrationBuilder.InsertData(
                table: "Uloga",
                columns: new[] { "UlogaId", "Naziv", "OpisUloge" },
                values: new object[,]
                {
                    { 1, "Admin", "Upravljanje sistemom" },
                    { 2, "Korisnik", "Pregled podataka" }
                });

            migrationBuilder.InsertData(
                table: "Uputnica",
                columns: new[] { "UputnicaId", "Datum", "Naziv", "Razlog" },
                values: new object[] { 6100, new DateTime(2022, 9, 4, 11, 13, 54, 180, DateTimeKind.Local).AddTicks(4824), "Posjeta orl doktora", "Upala uha" });

            migrationBuilder.InsertData(
                table: "Vakcinacija",
                columns: new[] { "VakcinacijaId", "NazivVakcine" },
                values: new object[] { 7111, "Pfizer" });

            migrationBuilder.InsertData(
                table: "Administrator",
                columns: new[] { "AdministratorId", "BolnicaId", "DatumRodjenja", "Email", "Ime", "Prebivaliste", "Prezime", "Telefon" },
                values: new object[] { 1007, 1000, "1998/12/16", "arijanahusic@gmail.com", "Arijana", "Sarajevo", "Husic", "063 246 022" });

            migrationBuilder.InsertData(
                table: "KorisnikUloga",
                columns: new[] { "KorisnikUlogeId", "DatumIzmjenje", "KorisnikId", "UlogaId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 2, 11, 13, 54, 149, DateTimeKind.Local).AddTicks(8895), 1001, 1 },
                    { 2, new DateTime(2022, 9, 2, 11, 13, 54, 163, DateTimeKind.Local).AddTicks(2023), 1002, 2 }
                });

            migrationBuilder.InsertData(
                table: "Odjel",
                columns: new[] { "OdjelId", "BolnicaId", "Naziv", "Telefon" },
                values: new object[,]
                {
                    { 2001, 1000, "Obiteljska medicina", "033/853-222" },
                    { 2002, 1000, "Stomatologija", "033/853-555" },
                    { 2003, 1000, "Neurologija", "033/853-552" },
                    { 2004, 1000, "Ginekologija", "033/853-553" },
                    { 2005, 1000, "Psihijatrija", "033/853-543" },
                    { 2006, 1000, "Pedijatrija", "033/853-743" }
                });

            migrationBuilder.InsertData(
                table: "Pacijent",
                columns: new[] { "PacijentId", "Alergican", "BrojKartona", "DatumRodjenja", "HronicneBolesti", "Ime", "JMBG", "Koagulopatije", "KorisnickoIme", "KorisnikId", "KrvnaGrupa", "LozinkaHash", "LozinkaSalt", "MjestoRodjenja", "Prebivaliste", "Prezime", "RhFaktor", "Spol", "Telefon" },
                values: new object[,]
                {
                    { 5001, "Ne", "14B579", "1998-12-11", "Nema", "Josip", "1211998796541", false, "pacijent1", 1002, "AB", "0xBZaX/f1WGPo+l/3IkzB55lLGY=", "9DtOOxfKEOqzx/vHnjsGLQ==", "Mostar", "Mostar", "Bojcic", "+", "M", "061 201 022" },
                    { 5002, "Antibiotik", "19378A", "1980-05-08", "Nema", "Helena", "5089801236547", false, "Pacijent2", 1002, "A", "O45OzDcnzIkz3i97ui6ExzI6kRk=", "9DtOOxfKEOqzx/vHnjsGLQ==", "Mostar", "Mostar", "Radic", "+", "Z", "062 201 022" },
                    { 5003, "Ne", "8537C", "1992-11-12", "Nema", "Melita", "5089801236547", false, "pacijent3", 1002, "AB", "r80ihzE7HGsM2xmAhL0HAjy4IaM=", "9DtOOxfKEOqzx/vHnjsGLQ==", "Stolac", "Mostar", "Golubica", "-", "Z", "063 991 022" }
                });

            migrationBuilder.InsertData(
                table: "Doktor",
                columns: new[] { "DoktorId", "DatumRodjenja", "Email", "Grad", "Ime", "JMBG", "OdjelId", "Prezime", "Spol", "Telefon" },
                values: new object[,]
                {
                    { 3001, "1998/12/15", "stanija@gmail.com", "Sarajevo", "STANIJA", "1215988789654", 2001, "TOKMAKČIJA", "Z", "063 246 022" },
                    { 3003, "1980-10-02", "jelenap@gmail.com", "Sarajevo", "Jelena", "1002980789654", 2006, "Pavlovic", "Z", "063 216 722" },
                    { 3005, "1990 - 07 - 05", "bznada@gmail.com", "Mostar", "Nada", "0507990078965", 2005, "Bazina", "Z", "062 216 722" },
                    { 3004, "1975-12-09", "markom@gmail.com", "Sarajevo", "Marko", "2099750789654", 2005, "Martinac", "M", "063 216 722" },
                    { 3006, "1989 - 06 - 28", "adnaz@gmail.com", "Mostar", "Adna", "2806989789654", 2004, "Zalihic", "Z", "061 216 722" },
                    { 3012, "1985 - 06 - 22", "sandrab@gmail.com", "Sarajevo", "Sandra", "2206985452136", 2003, "Brajkovic", "Z", "062 216 722" },
                    { 3002, "1988-01-02", "radas@gmail.com", "Mostar", "Rada", "0102988789654", 2006, "Šandrk", "Z", "063 246 722" },
                    { 3010, "1971 - 05 - 11", "gordanap@gmail.com", "Mostar", "Gordana", "1105971289654", 2001, "Pivic", "Z", "062 216 722" },
                    { 3009, "1971 - 03 - 22", "editas@gmail.com", "Stolac", "Edita", "2203197154239", 2001, "Sopta", "Z", "062 216 722" },
                    { 3008, "1970 - 11 - 11", "nikolinas@gmail.com", "Mostar", "Nikolina", "1111197523974", 2001, "Soce", "Z", "062 216 722" },
                    { 3007, "1980 - 02 - 03", "rankog@gmail.com", "Tuzla", "Ranko", "2039801236547", 2001, "Gacic", "M", "062 317 722" },
                    { 3011, "1980 - 11 - 19", "senadv@gmail.com", "Mostar", "Senad", "1911980647123", 2002, "Vujica", "M", "062 216 722" }
                });

            migrationBuilder.InsertData(
                table: "Nalaz",
                columns: new[] { "NalazId", "Datum", "LicnaAnamneza", "PacijentId", "PorodicnaAnamneza", "RadnaAnamneza" },
                values: new object[,]
                {
                    { 8001, "2021-12-22", "Upala uha", 5001, "Nema", "Nema" },
                    { 8002, "2021-04-05", "Ukljesten vrat", 5001, "Nema", "Nema" },
                    { 8003, "2022-03-22", "Upala pluca", 5002, "Secer", "Nema" },
                    { 8004, "2022-09-01", "Rutinska kontrola", 5003, "Nema", "Nema" }
                });

            migrationBuilder.InsertData(
                table: "PacijentOboljenje",
                columns: new[] { "OboljenjeId", "PacijentId", "NesposobanZaRad", "NesposobanZaRadDo", "NesposobanZaRadOd" },
                values: new object[] { 8010, 5002, "Ne", " ", " " });

            migrationBuilder.InsertData(
                table: "PacijentOsiguranje",
                columns: new[] { "OsiguranjeId", "PacijentId", "DatumOsiguranja", "Vazece" },
                values: new object[,]
                {
                    { 4003, 5003, new DateTime(2022, 9, 2, 11, 13, 54, 179, DateTimeKind.Local).AddTicks(445), true },
                    { 4001, 5001, new DateTime(2022, 9, 2, 11, 13, 54, 178, DateTimeKind.Local).AddTicks(8343), true },
                    { 4002, 5002, new DateTime(2022, 9, 2, 11, 13, 54, 179, DateTimeKind.Local).AddTicks(354), true }
                });

            migrationBuilder.InsertData(
                table: "PacijentVakcinacija",
                columns: new[] { "PacijentId", "VakcinacijaId", "Datum", "Doza", "Lokacija" },
                values: new object[] { 5002, 7111, "2021-12-22", 2, "Mostar" });

            migrationBuilder.InsertData(
                table: "PreventivneMjere",
                columns: new[] { "MjereId", "PacijentId", "Stanje" },
                values: new object[] { 8111, 5003, "Alergijska reakcija" });

            migrationBuilder.InsertData(
                table: "DodjeljeniDoktor",
                columns: new[] { "DoktorId", "PacijentId", "DatumOd" },
                values: new object[,]
                {
                    { 3001, 5001, new DateTime(2022, 9, 2, 11, 13, 54, 178, DateTimeKind.Local).AddTicks(2469) },
                    { 3007, 5002, new DateTime(2022, 9, 2, 11, 13, 54, 178, DateTimeKind.Local).AddTicks(3889) },
                    { 3008, 5003, new DateTime(2022, 9, 2, 11, 13, 54, 178, DateTimeKind.Local).AddTicks(3970) }
                });

            migrationBuilder.InsertData(
                table: "OcjenaDoktora",
                columns: new[] { "OcjenaId", "Anonimno", "DoktorId", "Ocjena", "Razlog" },
                values: new object[,]
                {
                    { 3100, true, 3001, 4, "Vrlo dobar" },
                    { 3300, true, 3009, 4, "Vrlo dobar" },
                    { 3200, true, 3002, 5, "Odlican" }
                });

            migrationBuilder.InsertData(
                table: "Pregled",
                columns: new[] { "PregledId", "Datum", "Dijagnoza", "DoktorId", "PacijentId", "RazlogPosjete", "TerapijaId", "UputnicaId" },
                values: new object[] { 6110, new DateTime(2022, 9, 2, 11, 13, 54, 180, DateTimeKind.Local).AddTicks(9977), "Upala srednjeg uha", 3001, 5001, "Bol  uhu i glava", 6001, 6100 });

            migrationBuilder.InsertData(
                table: "Termin",
                columns: new[] { "TerminId", "Datum", "DoktorId", "PacijentId", "Razlog", "Vrijeme" },
                values: new object[] { 7110, new DateTime(2022, 9, 2, 11, 13, 54, 185, DateTimeKind.Local).AddTicks(5829), 3009, 5001, "rutinska kontrola", "09:15:00" });

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_BolnicaId",
                table: "Administrator",
                column: "BolnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_DodjeljeniDoktor_DoktorId",
                table: "DodjeljeniDoktor",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Doktor_OdjelId",
                table: "Doktor",
                column: "OdjelId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloga_KorisnikId",
                table: "KorisnikUloga",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloga_UlogaId",
                table: "KorisnikUloga",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Nalaz_PacijentId",
                table: "Nalaz",
                column: "PacijentId");

            migrationBuilder.CreateIndex(
                name: "IX_OcjenaDoktora_DoktorId",
                table: "OcjenaDoktora",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Odjel_BolnicaId",
                table: "Odjel",
                column: "BolnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacijent_KorisnikId",
                table: "Pacijent",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_PacijentOboljenje_PacijentId",
                table: "PacijentOboljenje",
                column: "PacijentId");

            migrationBuilder.CreateIndex(
                name: "IX_PacijentOsiguranje_PacijentId",
                table: "PacijentOsiguranje",
                column: "PacijentId");

            migrationBuilder.CreateIndex(
                name: "IX_PacijentVakcinacija_PacijentId",
                table: "PacijentVakcinacija",
                column: "PacijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Pregled_DoktorId",
                table: "Pregled",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pregled_PacijentId",
                table: "Pregled",
                column: "PacijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Pregled_TerapijaId",
                table: "Pregled",
                column: "TerapijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pregled_UputnicaId",
                table: "Pregled",
                column: "UputnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_PreventivneMjere_PacijentId",
                table: "PreventivneMjere",
                column: "PacijentId");

            migrationBuilder.CreateIndex(
                name: "IX_SistematskiPregled_PacijentId",
                table: "SistematskiPregled",
                column: "PacijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Termin_DoktorId",
                table: "Termin",
                column: "DoktorId");

            migrationBuilder.CreateIndex(
                name: "IX_Termin_PacijentId",
                table: "Termin",
                column: "PacijentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrator");

            migrationBuilder.DropTable(
                name: "DodjeljeniDoktor");

            migrationBuilder.DropTable(
                name: "KorisnikUloga");

            migrationBuilder.DropTable(
                name: "Nalaz");

            migrationBuilder.DropTable(
                name: "OcjenaDoktora");

            migrationBuilder.DropTable(
                name: "PacijentOboljenje");

            migrationBuilder.DropTable(
                name: "PacijentOsiguranje");

            migrationBuilder.DropTable(
                name: "PacijentVakcinacija");

            migrationBuilder.DropTable(
                name: "Pregled");

            migrationBuilder.DropTable(
                name: "PreventivneMjere");

            migrationBuilder.DropTable(
                name: "SistematskiPregled");

            migrationBuilder.DropTable(
                name: "Termin");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "Oboljenje");

            migrationBuilder.DropTable(
                name: "Osiguranje");

            migrationBuilder.DropTable(
                name: "Vakcinacija");

            migrationBuilder.DropTable(
                name: "Terapija");

            migrationBuilder.DropTable(
                name: "Uputnica");

            migrationBuilder.DropTable(
                name: "Doktor");

            migrationBuilder.DropTable(
                name: "Pacijent");

            migrationBuilder.DropTable(
                name: "Odjel");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Bolnica");
        }
    }
}
