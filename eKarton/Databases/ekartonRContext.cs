using System;
using eKarton.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace eKarton.Databases
{
    public partial class ekartonRContext : DbContext
    {
        public ekartonRContext()
        {
        }

        public ekartonRContext(DbContextOptions<ekartonRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Bolnica> Bolnicas { get; set; }
        public virtual DbSet<DodjeljeniDoktor> DodjeljeniDoktors { get; set; }
        public virtual DbSet<Doktor> Doktors { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<KorisnikUloga> KorisnikUlogas { get; set; }
        public virtual DbSet<Nalaz> Nalazs { get; set; }
        public virtual DbSet<Oboljenje> Oboljenjes { get; set; }
        public virtual DbSet<OcjenaDoktora> OcjenaDoktoras { get; set; }
        public virtual DbSet<Odjel> Odjels { get; set; }
        public virtual DbSet<Osiguranje> Osiguranjes { get; set; }
        public virtual DbSet<Pacijent> Pacijents { get; set; }
        public virtual DbSet<PacijentOboljenje> PacijentOboljenjes { get; set; }
        public virtual DbSet<PacijentOsiguranje> PacijentOsiguranjes { get; set; }
        public virtual DbSet<PacijentVakcinacija> PacijentVakcinacijas { get; set; }
        public virtual DbSet<Pregled> Pregleds { get; set; }
        public virtual DbSet<PreventivneMjere> PreventivneMjeres { get; set; }
        public virtual DbSet<SistematskiPregled> SistematskiPregleds { get; set; }
        public virtual DbSet<Terapija> Terapijas { get; set; }
        public virtual DbSet<Termin> Termins { get; set; }
        public virtual DbSet<Uloga> Ulogas { get; set; }
        public virtual DbSet<Uputnica> Uputnicas { get; set; }
        public virtual DbSet<Vakcinacija> Vakcinacijas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-6E66B9L;Database=ekartonR;Trusted_Connection=True;User=seminarski;Password=st123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.ToTable("Administrator");

                entity.Property(e => e.AdministratorId).ValueGeneratedNever();

                entity.Property(e => e.DatumRodjenja)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Prebivaliste)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Bolnica)
                    .WithMany(p => p.Administrators)
                    .HasForeignKey(d => d.BolnicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdministratorBolnica");
            });

            modelBuilder.Entity<Bolnica>(entity =>
            {
                entity.ToTable("Bolnica");

                entity.Property(e => e.BolnicaId).ValueGeneratedNever();

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DodjeljeniDoktor>(entity =>
            {
                entity.HasKey(e => new { e.PacijentId, e.DoktorId });

                entity.ToTable("DodjeljeniDoktor");

                entity.Property(e => e.DatumOd).HasColumnType("date");

                entity.HasOne(d => d.Doktor)
                    .WithMany(p => p.DodjeljeniDoktors)
                    .HasForeignKey(d => d.DoktorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Dodjeljen__Dokto__3F466844");

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.DodjeljeniDoktors)
                    .HasForeignKey(d => d.PacijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Dodjeljen__Pacij__3E52440B");
            });

            modelBuilder.Entity<Doktor>(entity =>
            {
                entity.ToTable("Doktor");

                entity.Property(e => e.DoktorId).ValueGeneratedNever();

                entity.Property(e => e.DatumRodjenja)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Grad)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Jmbg)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("JMBG");

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Spol)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Odjel)
                    .WithMany(p => p.Doktors)
                    .HasForeignKey(d => d.OdjelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OdjelDoktor");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");

                entity.Property(e => e.KorisnikId).ValueGeneratedNever();

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<KorisnikUloga>(entity =>
            {
                entity.HasKey(e => e.KorisnikUlogeId)
                    .HasName("PK_KorisnikUloge");

                entity.ToTable("KorisnikUloga");

                entity.Property(e => e.KorisnikUlogeId).ValueGeneratedNever();

                entity.Property(e => e.DatumIzmjenje).HasColumnType("date");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnikUlogas)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisnikUloga");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisnikUlogas)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UlogaKorisnik");
            });
            

            modelBuilder.Entity<Nalaz>(entity =>
            {
                entity.ToTable("Nalaz");

                entity.Property(e => e.NalazId).ValueGeneratedNever();

                entity.Property(e => e.Datum)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LicnaAnamneza)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PorodicnaAnamneza)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RadnaAnamneza)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.Nalazs)
                    .HasForeignKey(d => d.PacijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NalazPacijent");
            });

            modelBuilder.Entity<Oboljenje>(entity =>
            {
                entity.ToTable("Oboljenje");

                entity.Property(e => e.OboljenjeId).ValueGeneratedNever();

                entity.Property(e => e.Dijagnoza)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Terapija)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OcjenaDoktora>(entity =>
            {
                entity.HasKey(e => e.OcjenaId)
                    .HasName("PK_Ocjena");

                entity.ToTable("OcjenaDoktora");

                entity.Property(e => e.OcjenaId).ValueGeneratedNever();

                entity.Property(e => e.Razlog)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Doktor)
                    .WithMany(p => p.OcjenaDoktoras)
                    .HasForeignKey(d => d.DoktorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OcjenaDoktora");
            });

            modelBuilder.Entity<Odjel>(entity =>
            {
                entity.ToTable("Odjel");

                entity.Property(e => e.OdjelId).ValueGeneratedNever();

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Bolnica)
                    .WithMany(p => p.Odjels)
                    .HasForeignKey(d => d.BolnicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OdjelBolnica");
            });

            modelBuilder.Entity<Osiguranje>(entity =>
            {
                entity.ToTable("Osiguranje");

                entity.Property(e => e.OsiguranjeId).ValueGeneratedNever();

                entity.Property(e => e.Osiguranik)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Pacijent>(entity =>
            {
                entity.ToTable("Pacijent");

                entity.Property(e => e.PacijentId).ValueGeneratedNever();

                entity.Property(e => e.Alergican)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BrojKartona)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DatumRodjenja)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.HronicneBolesti)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Jmbg)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("JMBG");

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.KrvnaGrupa)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MjestoRodjenja)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Prebivaliste)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RhFaktor)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Spol)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Pacijents)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PacijentKorisnik");
            });

            modelBuilder.Entity<PacijentOboljenje>(entity =>
            {
                entity.HasKey(e => new { e.OboljenjeId, e.PacijentId });

                entity.ToTable("PacijentOboljenje");

                entity.Property(e => e.NesposobanZaRad).HasMaxLength(20);

                entity.Property(e => e.NesposobanZaRadDo).HasMaxLength(20);

                entity.Property(e => e.NesposobanZaRadOd).HasMaxLength(20);

                entity.HasOne(d => d.Oboljenje)
                    .WithMany(p => p.PacijentOboljenjes)
                    .HasForeignKey(d => d.OboljenjeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PacijentO__Obolj__60A75C0F");

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.PacijentOboljenjes)
                    .HasForeignKey(d => d.PacijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PacijentO__Pacij__619B8048");
            });

            modelBuilder.Entity<PacijentOsiguranje>(entity =>
            {
                entity.HasKey(e => new { e.OsiguranjeId, e.PacijentId })
                    .HasName("FK_PacijentOsiguranje");

                entity.ToTable("PacijentOsiguranje");

                entity.Property(e => e.DatumOsiguranja).HasColumnType("date");

                entity.HasOne(d => d.Osiguranje)
                    .WithMany(p => p.PacijentOsiguranjes)
                    .HasForeignKey(d => d.OsiguranjeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PacijentO__Osigu__4222D4EF");

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.PacijentOsiguranjes)
                    .HasForeignKey(d => d.PacijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PacijentO__Pacij__4316F928");
            });

            modelBuilder.Entity<PacijentVakcinacija>(entity =>
            {
                entity.HasKey(e => new { e.VakcinacijaId, e.PacijentId })
                    .HasName("FK_PacijentVakcinacija");

                entity.ToTable("PacijentVakcinacija");

                entity.Property(e => e.Datum)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Lokacija)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.PacijentVakcinacijas)
                    .HasForeignKey(d => d.PacijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PacijentV__Pacij__59063A47");

                entity.HasOne(d => d.Vakcinacija)
                    .WithMany(p => p.PacijentVakcinacijas)
                    .HasForeignKey(d => d.VakcinacijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PacijentV__Vakci__5812160E");
            });

            modelBuilder.Entity<Pregled>(entity =>
            {
                entity.ToTable("Pregled");

                entity.Property(e => e.PregledId).ValueGeneratedNever();

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Dijagnoza)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RazlogPosjete)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Doktor)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.DoktorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PregledDoktor");

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.PacijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PregledPacijent");

                entity.HasOne(d => d.Terapija)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.TerapijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PregledTerapija");

                entity.HasOne(d => d.Uputnica)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.UputnicaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PregledUputnica");
            });

            modelBuilder.Entity<PreventivneMjere>(entity =>
            {
                entity.HasKey(e => e.MjereId)
                    .HasName("PK_Mjere");

                entity.ToTable("PreventivneMjere");

                entity.Property(e => e.MjereId).ValueGeneratedNever();

                entity.Property(e => e.Stanje)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.PreventivneMjeres)
                    .HasForeignKey(d => d.PacijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PreventivneMjerePacijent");
            });

            modelBuilder.Entity<SistematskiPregled>(entity =>
            {
                entity.ToTable("SistematskiPregled");

                entity.Property(e => e.SistematskiPregledId).ValueGeneratedNever();

                entity.Property(e => e.Abdomen).HasMaxLength(50);

                entity.Property(e => e.Bmi)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("BMI");

                entity.Property(e => e.Cula).HasMaxLength(50);

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Ekstremiteti).HasMaxLength(50);

                entity.Property(e => e.GrudniKos).HasMaxLength(50);

                entity.Property(e => e.KicmeniStub).HasMaxLength(50);

                entity.Property(e => e.KrvniPritisak).HasMaxLength(20);

                entity.Property(e => e.ObimGrudi).HasMaxLength(50);

                entity.Property(e => e.ObimStruka).HasMaxLength(50);

                entity.Property(e => e.Pluca).HasMaxLength(50);

                entity.Property(e => e.PromjeneNaKozi).HasMaxLength(50);

                entity.Property(e => e.Puls).HasMaxLength(20);

                entity.Property(e => e.Tezina).HasMaxLength(100);

                entity.Property(e => e.Tonzile).HasMaxLength(50);

                entity.Property(e => e.Visina).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Vrat).HasMaxLength(50);

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.SistematskiPregleds)
                    .HasForeignKey(d => d.PacijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SistematskiPRegledPacijent");
            });

            modelBuilder.Entity<Terapija>(entity =>
            {
                entity.ToTable("Terapija");

                entity.Property(e => e.TerapijaId).ValueGeneratedNever();

                entity.Property(e => e.Do)
                    .HasColumnType("date")
                    .HasColumnName("DO");

                entity.Property(e => e.NazivLijekova)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Od)
                    .HasColumnType("date")
                    .HasColumnName("OD");

                entity.Property(e => e.Podsjetnik).HasMaxLength(30);

                entity.Property(e => e.Uputa)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Termin>(entity =>
            {
                entity.ToTable("Termin");

                entity.Property(e => e.TerminId).ValueGeneratedNever();

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Razlog)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Vrijeme)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Doktor)
                    .WithMany(p => p.Termins)
                    .HasForeignKey(d => d.DoktorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminDoktor");

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.Termins)
                    .HasForeignKey(d => d.PacijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminPacijent");
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.ToTable("Uloga");

                entity.Property(e => e.UlogaId).ValueGeneratedNever();

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.OpisUloge).HasMaxLength(50);
            });

            modelBuilder.Entity<Uputnica>(entity =>
            {
                entity.ToTable("Uputnica");

                entity.Property(e => e.UputnicaId).ValueGeneratedNever();

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Razlog)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Vakcinacija>(entity =>
            {
                entity.ToTable("Vakcinacija");

                entity.Property(e => e.VakcinacijaId).ValueGeneratedNever();

                entity.Property(e => e.NazivVakcine)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Seed();
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
