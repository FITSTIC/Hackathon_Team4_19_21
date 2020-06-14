using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fitstic_Hackathon_4.Migrations
{
    public partial class RelDb_EndingFixingClasses_WithAllHasData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabDocenti",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    Cognome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    DataNascita = table.Column<DateTime>(nullable: false),
                    DataAssunzione = table.Column<DateTime>(nullable: false),
                    NumTelefono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabDocenti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabOrganizzatori",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    Cognome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    DataNascita = table.Column<DateTime>(nullable: false),
                    DataAssunzione = table.Column<DateTime>(nullable: false),
                    NumTelefono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabOrganizzatori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabTutor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    Cognome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    DataNascita = table.Column<DateTime>(nullable: false),
                    DataAssunzione = table.Column<DateTime>(nullable: false),
                    NumTelefono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabTutor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabCorsi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    AnnoAccademico = table.Column<string>(nullable: false),
                    DataInizio = table.Column<DateTime>(nullable: false),
                    DataFine = table.Column<DateTime>(nullable: false),
                    Sede = table.Column<string>(nullable: true),
                    OrganizzatoreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabCorsi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabCorsi_TabOrganizzatori_OrganizzatoreId",
                        column: x => x.OrganizzatoreId,
                        principalTable: "TabOrganizzatori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TabModuli",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    DataInizio = table.Column<DateTime>(nullable: false),
                    DataFine = table.Column<DateTime>(nullable: false),
                    Materia = table.Column<string>(nullable: true),
                    TutorId = table.Column<int>(nullable: true),
                    DocenteId = table.Column<int>(nullable: true),
                    CorsoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabModuli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabModuli_TabCorsi_CorsoId",
                        column: x => x.CorsoId,
                        principalTable: "TabCorsi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TabModuli_TabDocenti_DocenteId",
                        column: x => x.DocenteId,
                        principalTable: "TabDocenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TabModuli_TabTutor_TutorId",
                        column: x => x.TutorId,
                        principalTable: "TabTutor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TabPartecipanti",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    Cognome = table.Column<string>(nullable: true),
                    DataNascita = table.Column<DateTime>(nullable: false),
                    Citta = table.Column<string>(nullable: true),
                    Indirizzo = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    TipoDiploma = table.Column<string>(nullable: true),
                    AnnoDiploma = table.Column<DateTime>(nullable: false),
                    CorsoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabPartecipanti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabPartecipanti_TabCorsi_CorsoId",
                        column: x => x.CorsoId,
                        principalTable: "TabCorsi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TabEsami",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<DateTime>(nullable: false),
                    Punteggio = table.Column<int>(nullable: false),
                    ModuloId = table.Column<int>(nullable: false),
                    PartecipanteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabEsami", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabEsami_TabModuli_ModuloId",
                        column: x => x.ModuloId,
                        principalTable: "TabModuli",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabEsami_TabPartecipanti_PartecipanteId",
                        column: x => x.PartecipanteId,
                        principalTable: "TabPartecipanti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TabIscrizioni",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataIscrizione = table.Column<DateTime>(nullable: false),
                    CorsoId = table.Column<int>(nullable: false),
                    PartecipanteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabIscrizioni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabIscrizioni_TabCorsi_CorsoId",
                        column: x => x.CorsoId,
                        principalTable: "TabCorsi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TabIscrizioni_TabPartecipanti_PartecipanteId",
                        column: x => x.PartecipanteId,
                        principalTable: "TabPartecipanti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TabDocenti",
                columns: new[] { "Id", "Cognome", "DataAssunzione", "DataNascita", "Email", "Nome", "NumTelefono" },
                values: new object[] { 1, "Armeni", new DateTime(2020, 6, 14, 11, 24, 45, 414, DateTimeKind.Local).AddTicks(6032), new DateTime(1974, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "d.armeni@gmail.com", "Daniele", 123456 });

            migrationBuilder.InsertData(
                table: "TabDocenti",
                columns: new[] { "Id", "Cognome", "DataAssunzione", "DataNascita", "Email", "Nome", "NumTelefono" },
                values: new object[] { 2, "Martini", new DateTime(2020, 6, 14, 11, 24, 45, 414, DateTimeKind.Local).AddTicks(6071), new DateTime(1984, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "luca.mart84@gmail.com", "Luca", 123456 });

            migrationBuilder.InsertData(
                table: "TabOrganizzatori",
                columns: new[] { "Id", "Cognome", "DataAssunzione", "DataNascita", "Email", "Nome", "NumTelefono" },
                values: new object[] { 3, "Simonini", new DateTime(2020, 6, 14, 11, 24, 45, 413, DateTimeKind.Local).AddTicks(8403), new DateTime(1986, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "l.simo@gmail.com", "Luciana", 33516523 });

            migrationBuilder.InsertData(
                table: "TabOrganizzatori",
                columns: new[] { "Id", "Cognome", "DataAssunzione", "DataNascita", "Email", "Nome", "NumTelefono" },
                values: new object[] { 4, "Bartoli", new DateTime(2020, 6, 14, 11, 24, 45, 413, DateTimeKind.Local).AddTicks(8535), new DateTime(1976, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "g.bartoli@gmail.com", "Giuseppe", 3351743 });

            migrationBuilder.InsertData(
                table: "TabPartecipanti",
                columns: new[] { "Id", "AnnoDiploma", "Citta", "Cognome", "CorsoId", "DataNascita", "Email", "Indirizzo", "Nome", "Telefono", "TipoDiploma" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1994), "MODENA", " Mariucci", null, new DateTime(1974, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "gisella.mariucci@gmail.com", "Via Stretta, 48", "Gisella", "3289632147", "Liceo Scientifico" });

            migrationBuilder.InsertData(
                table: "TabPartecipanti",
                columns: new[] { "Id", "AnnoDiploma", "Citta", "Cognome", "CorsoId", "DataNascita", "Email", "Indirizzo", "Nome", "Telefono", "TipoDiploma" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2004), "RIMINI", " Menicucci", null, new DateTime(1984, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "antonio.maenicucci@gmail.com", "Via Nazionale, 57", "Antonio", "3289632147", "Tecnico Agrario" });

            migrationBuilder.InsertData(
                table: "TabTutor",
                columns: new[] { "Id", "Cognome", "DataAssunzione", "DataNascita", "Email", "Nome", "NumTelefono" },
                values: new object[] { 2, "Sarzanelli", new DateTime(2020, 6, 14, 11, 24, 45, 408, DateTimeKind.Local).AddTicks(902), new DateTime(1984, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "m.sarzanelli84@gmail.com", "Mario", 123456 });

            migrationBuilder.InsertData(
                table: "TabCorsi",
                columns: new[] { "Id", "AnnoAccademico", "DataFine", "DataInizio", "Nome", "OrganizzatoreId", "Sede" },
                values: new object[] { 1, "2019-2021", new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cristoforo Colombo", 3, "CASALECCHIO DI R." });

            migrationBuilder.InsertData(
                table: "TabCorsi",
                columns: new[] { "Id", "AnnoAccademico", "DataFine", "DataInizio", "Nome", "OrganizzatoreId", "Sede" },
                values: new object[] { 2, "2019-2021", new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alan Turing", 3, "CESENA" });

            migrationBuilder.InsertData(
                table: "TabModuli",
                columns: new[] { "Id", "CorsoId", "DataFine", "DataInizio", "DocenteId", "Materia", "Nome", "TutorId" },
                values: new object[] { 3, null, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "CLOUD", "PROGRAMMAZIONE CLOUD", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TabCorsi_OrganizzatoreId",
                table: "TabCorsi",
                column: "OrganizzatoreId");

            migrationBuilder.CreateIndex(
                name: "IX_TabEsami_ModuloId",
                table: "TabEsami",
                column: "ModuloId");

            migrationBuilder.CreateIndex(
                name: "IX_TabEsami_PartecipanteId",
                table: "TabEsami",
                column: "PartecipanteId");

            migrationBuilder.CreateIndex(
                name: "IX_TabIscrizioni_CorsoId",
                table: "TabIscrizioni",
                column: "CorsoId");

            migrationBuilder.CreateIndex(
                name: "IX_TabIscrizioni_PartecipanteId",
                table: "TabIscrizioni",
                column: "PartecipanteId");

            migrationBuilder.CreateIndex(
                name: "IX_TabModuli_CorsoId",
                table: "TabModuli",
                column: "CorsoId");

            migrationBuilder.CreateIndex(
                name: "IX_TabModuli_DocenteId",
                table: "TabModuli",
                column: "DocenteId");

            migrationBuilder.CreateIndex(
                name: "IX_TabModuli_TutorId",
                table: "TabModuli",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_TabPartecipanti_CorsoId",
                table: "TabPartecipanti",
                column: "CorsoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "TabEsami");

            migrationBuilder.DropTable(
                name: "TabIscrizioni");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TabModuli");

            migrationBuilder.DropTable(
                name: "TabPartecipanti");

            migrationBuilder.DropTable(
                name: "TabDocenti");

            migrationBuilder.DropTable(
                name: "TabTutor");

            migrationBuilder.DropTable(
                name: "TabCorsi");

            migrationBuilder.DropTable(
                name: "TabOrganizzatori");
        }
    }
}
