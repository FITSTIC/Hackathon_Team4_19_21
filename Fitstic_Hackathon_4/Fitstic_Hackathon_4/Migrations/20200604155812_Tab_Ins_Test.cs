using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fitstic_Hackathon_4.Migrations
{
    public partial class Tab_Ins_Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TabEsami",
                columns: new[] { "IdEsame", "Data", "IdModulo", "IdPartecipante", "Punteggio" },
                values: new object[] { 50, new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 56, 2 });

            migrationBuilder.InsertData(
                table: "TabOperatori",
                columns: new[] { "IdPers", "Cognome", "DataAssunzione", "DataNascita", "Email", "Nome", "NumTelefono" },
                values: new object[] { 1, "Verdi", new DateTime(2020, 6, 4, 17, 58, 11, 789, DateTimeKind.Local).AddTicks(731), new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sonobello@gmail.com", "Mario", 123456 });

            migrationBuilder.InsertData(
                table: "TabPartecipanti",
                columns: new[] { "IdPart", "AnnoDiploma", "Citta", "Cognome", "DataNascita", "Email", "Indirizzo", "Nome", "Telefono", "TipoDiploma" },
                values: new object[] { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2000), "Brisighella", " Bianchi", new DateTime(2000, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "eccomi@gmail.com", "Via Larga, 45", "Aldo", "15874", "Tecnico Elettronico" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TabEsami",
                keyColumn: "IdEsame",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TabOperatori",
                keyColumn: "IdPers",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TabPartecipanti",
                keyColumn: "IdPart",
                keyValue: 56);
        }
    }
}
