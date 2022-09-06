using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eKarton.Migrations
{
    public partial class DoradaDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DodjeljeniDoktor",
                keyColumns: new[] { "DoktorId", "PacijentId" },
                keyValues: new object[] { 3001, 5001 },
                column: "DatumOd",
                value: new DateTime(2022, 9, 6, 17, 18, 11, 7, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "DodjeljeniDoktor",
                keyColumns: new[] { "DoktorId", "PacijentId" },
                keyValues: new object[] { 3007, 5002 },
                column: "DatumOd",
                value: new DateTime(2022, 9, 6, 17, 18, 11, 7, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "DodjeljeniDoktor",
                keyColumns: new[] { "DoktorId", "PacijentId" },
                keyValues: new object[] { 3008, 5003 },
                column: "DatumOd",
                value: new DateTime(2022, 9, 6, 17, 18, 11, 7, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 1001,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "A95QMVtPhi9ytV/8yptWkKW+DII=", "vJHSCL84HIlrmRh3IDi2xQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 1002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "GyULwSUsx6yjVJjkhgRbiYtACEA=", "NayVJoOmWY/EGaOHOGSloA==" });

            migrationBuilder.UpdateData(
                table: "KorisnikUloga",
                keyColumn: "KorisnikUlogeId",
                keyValue: 1,
                column: "DatumIzmjenje",
                value: new DateTime(2022, 9, 6, 17, 18, 10, 988, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "KorisnikUloga",
                keyColumn: "KorisnikUlogeId",
                keyValue: 2,
                column: "DatumIzmjenje",
                value: new DateTime(2022, 9, 6, 17, 18, 10, 996, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "PacijentId",
                keyValue: 5001,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "VDn/gN4rwJELlF9JYzlWw98rDXU=", "0CDSZGjX188UVwcU/vTeqg==" });

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "PacijentId",
                keyValue: 5002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "PiJkdSuC9iPm5I1gTmJe5fuAXps=", "0CDSZGjX188UVwcU/vTeqg==" });

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "PacijentId",
                keyValue: 5003,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "HROygw0nJ3t/8Bfa1T0MTQSAiCk=", "0CDSZGjX188UVwcU/vTeqg==" });

            migrationBuilder.UpdateData(
                table: "PacijentOsiguranje",
                keyColumns: new[] { "OsiguranjeId", "PacijentId" },
                keyValues: new object[] { 4001, 5001 },
                column: "DatumOsiguranja",
                value: new DateTime(2022, 9, 6, 17, 18, 11, 8, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "PacijentOsiguranje",
                keyColumns: new[] { "OsiguranjeId", "PacijentId" },
                keyValues: new object[] { 4002, 5002 },
                column: "DatumOsiguranja",
                value: new DateTime(2022, 9, 6, 17, 18, 11, 8, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "PacijentOsiguranje",
                keyColumns: new[] { "OsiguranjeId", "PacijentId" },
                keyValues: new object[] { 4003, 5003 },
                column: "DatumOsiguranja",
                value: new DateTime(2022, 9, 6, 17, 18, 11, 8, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Pregled",
                keyColumn: "PregledId",
                keyValue: 6110,
                column: "Datum",
                value: new DateTime(2022, 9, 6, 17, 18, 11, 10, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Terapija",
                keyColumn: "TerapijaId",
                keyValue: 6001,
                columns: new[] { "DO", "OD" },
                values: new object[] { new DateTime(2022, 9, 13, 17, 18, 11, 9, DateTimeKind.Local).AddTicks(2195), new DateTime(2022, 9, 6, 17, 18, 11, 9, DateTimeKind.Local).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 7110,
                column: "Datum",
                value: new DateTime(2022, 9, 6, 17, 18, 11, 11, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Uputnica",
                keyColumn: "UputnicaId",
                keyValue: 6100,
                column: "Datum",
                value: new DateTime(2022, 9, 8, 17, 18, 11, 9, DateTimeKind.Local).AddTicks(7955));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DodjeljeniDoktor",
                keyColumns: new[] { "DoktorId", "PacijentId" },
                keyValues: new object[] { 3001, 5001 },
                column: "DatumOd",
                value: new DateTime(2022, 9, 2, 11, 13, 54, 178, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "DodjeljeniDoktor",
                keyColumns: new[] { "DoktorId", "PacijentId" },
                keyValues: new object[] { 3007, 5002 },
                column: "DatumOd",
                value: new DateTime(2022, 9, 2, 11, 13, 54, 178, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "DodjeljeniDoktor",
                keyColumns: new[] { "DoktorId", "PacijentId" },
                keyValues: new object[] { 3008, 5003 },
                column: "DatumOd",
                value: new DateTime(2022, 9, 2, 11, 13, 54, 178, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 1001,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "1Ikzb+4T3m/mSsSAR/nHhHf76fg=", "IPO1Gbirb4VplijalXCMJA==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "KorisnikId",
                keyValue: 1002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "tYVhM9e1TpmlQVGMlm9/Q3tkeEQ=", "RH0O7zwBCMV4DgpZNcdDQQ==" });

            migrationBuilder.UpdateData(
                table: "KorisnikUloga",
                keyColumn: "KorisnikUlogeId",
                keyValue: 1,
                column: "DatumIzmjenje",
                value: new DateTime(2022, 9, 2, 11, 13, 54, 149, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "KorisnikUloga",
                keyColumn: "KorisnikUlogeId",
                keyValue: 2,
                column: "DatumIzmjenje",
                value: new DateTime(2022, 9, 2, 11, 13, 54, 163, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "PacijentId",
                keyValue: 5001,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "0xBZaX/f1WGPo+l/3IkzB55lLGY=", "9DtOOxfKEOqzx/vHnjsGLQ==" });

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "PacijentId",
                keyValue: 5002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "O45OzDcnzIkz3i97ui6ExzI6kRk=", "9DtOOxfKEOqzx/vHnjsGLQ==" });

            migrationBuilder.UpdateData(
                table: "Pacijent",
                keyColumn: "PacijentId",
                keyValue: 5003,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "r80ihzE7HGsM2xmAhL0HAjy4IaM=", "9DtOOxfKEOqzx/vHnjsGLQ==" });

            migrationBuilder.UpdateData(
                table: "PacijentOsiguranje",
                keyColumns: new[] { "OsiguranjeId", "PacijentId" },
                keyValues: new object[] { 4001, 5001 },
                column: "DatumOsiguranja",
                value: new DateTime(2022, 9, 2, 11, 13, 54, 178, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "PacijentOsiguranje",
                keyColumns: new[] { "OsiguranjeId", "PacijentId" },
                keyValues: new object[] { 4002, 5002 },
                column: "DatumOsiguranja",
                value: new DateTime(2022, 9, 2, 11, 13, 54, 179, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "PacijentOsiguranje",
                keyColumns: new[] { "OsiguranjeId", "PacijentId" },
                keyValues: new object[] { 4003, 5003 },
                column: "DatumOsiguranja",
                value: new DateTime(2022, 9, 2, 11, 13, 54, 179, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Pregled",
                keyColumn: "PregledId",
                keyValue: 6110,
                column: "Datum",
                value: new DateTime(2022, 9, 2, 11, 13, 54, 180, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Terapija",
                keyColumn: "TerapijaId",
                keyValue: 6001,
                columns: new[] { "DO", "OD" },
                values: new object[] { new DateTime(2022, 9, 9, 11, 13, 54, 179, DateTimeKind.Local).AddTicks(8403), new DateTime(2022, 9, 2, 11, 13, 54, 179, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 7110,
                column: "Datum",
                value: new DateTime(2022, 9, 2, 11, 13, 54, 185, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Uputnica",
                keyColumn: "UputnicaId",
                keyValue: 6100,
                column: "Datum",
                value: new DateTime(2022, 9, 4, 11, 13, 54, 180, DateTimeKind.Local).AddTicks(4824));
        }
    }
}
