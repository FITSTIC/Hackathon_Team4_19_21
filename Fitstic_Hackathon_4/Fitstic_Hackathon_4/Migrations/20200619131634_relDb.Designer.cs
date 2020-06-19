﻿// <auto-generated />
using System;
using Fitstic_Hackathon_4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fitstic_Hackathon_4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200619131634_relDb")]
    partial class relDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("Fitstic_Hackathon_4.Data.Corso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AnnoAccademico")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataFine")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInizio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("OrganizzatoreId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sede")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrganizzatoreId");

                    b.ToTable("TabCorsi");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnnoAccademico = "2019-2021",
                            DataFine = new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInizio = new DateTime(2019, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Cristoforo Colombo",
                            OrganizzatoreId = 3,
                            Sede = "CASALECCHIO DI R."
                        },
                        new
                        {
                            Id = 2,
                            AnnoAccademico = "2019-2021",
                            DataFine = new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInizio = new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nome = "Alan Turing",
                            OrganizzatoreId = 3,
                            Sede = "CESENA"
                        });
                });

            modelBuilder.Entity("Fitstic_Hackathon_4.Data.Docente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataAssunzione")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNascita")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumTelefono")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TabDocenti");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cognome = "Armeni",
                            DataAssunzione = new DateTime(2020, 6, 19, 15, 16, 33, 229, DateTimeKind.Local).AddTicks(7336),
                            DataNascita = new DateTime(1974, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "d.armeni@gmail.com",
                            Nome = "Daniele",
                            NumTelefono = 123456
                        },
                        new
                        {
                            Id = 2,
                            Cognome = "Martini",
                            DataAssunzione = new DateTime(2020, 6, 19, 15, 16, 33, 229, DateTimeKind.Local).AddTicks(7371),
                            DataNascita = new DateTime(1984, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "luca.mart84@gmail.com",
                            Nome = "Luca",
                            NumTelefono = 123456
                        });
                });

            modelBuilder.Entity("Fitstic_Hackathon_4.Data.Esame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int>("ModuloId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("PartecipanteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Punteggio")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ModuloId");

                    b.HasIndex("PartecipanteId");

                    b.ToTable("TabEsami");
                });

            modelBuilder.Entity("Fitstic_Hackathon_4.Data.Iscrizione", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CorsoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataIscrizione")
                        .HasColumnType("TEXT");

                    b.Property<int>("PartecipanteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CorsoId");

                    b.HasIndex("PartecipanteId");

                    b.ToTable("TabIscrizioni");
                });

            modelBuilder.Entity("Fitstic_Hackathon_4.Data.Modulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CorsoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataFine")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInizio")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DocenteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Materia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("TutorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CorsoId");

                    b.HasIndex("DocenteId");

                    b.HasIndex("TutorId");

                    b.ToTable("TabModuli");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            DataFine = new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataInizio = new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocenteId = 1,
                            Materia = "CLOUD",
                            Nome = "PROGRAMMAZIONE CLOUD",
                            TutorId = 2
                        });
                });

            modelBuilder.Entity("Fitstic_Hackathon_4.Data.Organizzatore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataAssunzione")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNascita")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumTelefono")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TabOrganizzatori");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Cognome = "Simonini",
                            DataAssunzione = new DateTime(2020, 6, 19, 15, 16, 33, 228, DateTimeKind.Local).AddTicks(9801),
                            DataNascita = new DateTime(1986, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "l.simo@gmail.com",
                            Nome = "Luciana",
                            NumTelefono = 33516523
                        },
                        new
                        {
                            Id = 4,
                            Cognome = "Bartoli",
                            DataAssunzione = new DateTime(2020, 6, 19, 15, 16, 33, 228, DateTimeKind.Local).AddTicks(9937),
                            DataNascita = new DateTime(1976, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "g.bartoli@gmail.com",
                            Nome = "Giuseppe",
                            NumTelefono = 3351743
                        });
                });

            modelBuilder.Entity("Fitstic_Hackathon_4.Data.Partecipante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AnnoDiploma")
                        .HasColumnType("TEXT");

                    b.Property<string>("Citta")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cognome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CorsoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataNascita")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Indirizzo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoDiploma")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CorsoId");

                    b.ToTable("TabPartecipanti");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            AnnoDiploma = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1994),
                            Citta = "MODENA",
                            Cognome = " Mariucci",
                            DataNascita = new DateTime(1974, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "gisella.mariucci@gmail.com",
                            Indirizzo = "Via Stretta, 48",
                            Nome = "Gisella",
                            Telefono = "3289632147",
                            TipoDiploma = "Liceo Scientifico"
                        },
                        new
                        {
                            Id = 5,
                            AnnoDiploma = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2004),
                            Citta = "RIMINI",
                            Cognome = " Menicucci",
                            DataNascita = new DateTime(1984, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "antonio.maenicucci@gmail.com",
                            Indirizzo = "Via Nazionale, 57",
                            Nome = "Antonio",
                            Telefono = "3289632147",
                            TipoDiploma = "Tecnico Agrario"
                        });
                });

            modelBuilder.Entity("Fitstic_Hackathon_4.Data.Tutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataAssunzione")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNascita")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumTelefono")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TabTutor");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Cognome = "Sarzanelli",
                            DataAssunzione = new DateTime(2020, 6, 19, 15, 16, 33, 222, DateTimeKind.Local).AddTicks(8976),
                            DataNascita = new DateTime(1984, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "m.sarzanelli84@gmail.com",
                            Nome = "Mario",
                            NumTelefono = 123456
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Fitstic_Hackathon_4.Data.Corso", b =>
                {
                    b.HasOne("Fitstic_Hackathon_4.Data.Organizzatore", "Organizzatore")
                        .WithMany()
                        .HasForeignKey("OrganizzatoreId");
                });

            modelBuilder.Entity("Fitstic_Hackathon_4.Data.Esame", b =>
                {
                    b.HasOne("Fitstic_Hackathon_4.Data.Modulo", "Modulo")
                        .WithMany()
                        .HasForeignKey("ModuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fitstic_Hackathon_4.Data.Partecipante", "Partecipante")
                        .WithMany()
                        .HasForeignKey("PartecipanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fitstic_Hackathon_4.Data.Iscrizione", b =>
                {
                    b.HasOne("Fitstic_Hackathon_4.Data.Corso", "Corso")
                        .WithMany()
                        .HasForeignKey("CorsoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fitstic_Hackathon_4.Data.Partecipante", "Partecipante")
                        .WithMany()
                        .HasForeignKey("PartecipanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fitstic_Hackathon_4.Data.Modulo", b =>
                {
                    b.HasOne("Fitstic_Hackathon_4.Data.Corso", "Corso")
                        .WithMany("ListaModuli")
                        .HasForeignKey("CorsoId");

                    b.HasOne("Fitstic_Hackathon_4.Data.Docente", "Docente")
                        .WithMany()
                        .HasForeignKey("DocenteId");

                    b.HasOne("Fitstic_Hackathon_4.Data.Tutor", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorId");
                });

            modelBuilder.Entity("Fitstic_Hackathon_4.Data.Partecipante", b =>
                {
                    b.HasOne("Fitstic_Hackathon_4.Data.Corso", null)
                        .WithMany("ListaPartecipanti")
                        .HasForeignKey("CorsoId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
