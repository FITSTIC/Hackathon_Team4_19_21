using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fitstic_Hackathon_4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Docente> TabDocenti { get; set; }
        public DbSet<Organizzatore> TabOrganizzatori { get; set; }
        public DbSet<Tutor> TabTutor { get; set; }
        public DbSet<Modulo> TabModuli { get; set; }
        public DbSet<Partecipante> TabPartecipanti { get; set; }
        public DbSet<Esame> TabEsami { get; set; }
        public DbSet<Corso> TabCorsi { get; set; }
        public DbSet<Iscrizione> TabIscrizioni { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Tutor>().HasData(
                new Tutor
                {   
                    Id = 2,
                    Nome = "Mario",
                    Cognome = "Sarzanelli",
                    NumTelefono = 123456,
                    Email = "m.sarzanelli84@gmail.com",
                    DataAssunzione = DateTime.Now,
                    DataNascita = new DateTime(1984, 12, 07)

                });

            builder.Entity<Organizzatore>().HasData(
                new Organizzatore
                {
                    Id = 3,
                    Nome = "Luciana",
                    Cognome = "Simonini",
                    NumTelefono = 33516523,
                    Email = "l.simo@gmail.com",
                    DataAssunzione = DateTime.Now,
                    DataNascita = new DateTime(1986, 04, 18)

                },

                new Organizzatore
                {
                    Id = 4,
                    Nome = "Giuseppe",
                    Cognome = "Bartoli",
                    NumTelefono = 3351743,
                    Email = "g.bartoli@gmail.com",
                    DataAssunzione = DateTime.Now,
                    DataNascita = new DateTime(1976, 06, 13)

                });

            builder.Entity<Partecipante>().HasData(
               new Partecipante
               {
                   Id = 3,
                   DataNascita = new DateTime(1974, 06, 15),
                   Citta = "MODENA",
                   Nome = "Gisella",
                   Cognome = " Mariucci",
                   Email = "gisella.mariucci@gmail.com",
                   Telefono = "3289632147",
                   AnnoDiploma = new DateTime(1994),
                   TipoDiploma = "Liceo Scientifico",
                   Indirizzo = "Via Stretta, 48"

               },

               new Partecipante
               {
                   Id = 5,
                   DataNascita = new DateTime(1984, 07, 25),
                   Citta = "RIMINI",
                   Nome = "Antonio",
                   Cognome = " Menicucci",
                   Email = "antonio.maenicucci@gmail.com",
                   Telefono = "3289632147",
                   AnnoDiploma = new DateTime(2004),
                   TipoDiploma = "Tecnico Agrario",
                   Indirizzo = "Via Nazionale, 57"

               });

            builder.Entity<Docente>().HasData(
                new Docente
                {
                    Id = 1,
                    Nome = "Daniele",
                    Cognome = "Armeni",
                    NumTelefono = 123456,
                    Email = "d.armeni@gmail.com",
                    DataAssunzione = DateTime.Now,
                    DataNascita = new DateTime(1974, 12, 07)

                },
           
                new Docente
                {
                    Id = 2,
                    Nome = "Luca",
                    Cognome = "Martini",
                    NumTelefono = 123456,
                    Email = "luca.mart84@gmail.com",
                    DataAssunzione = DateTime.Now,
                    DataNascita = new DateTime(1984, 11, 09)
                });

                


            builder.Entity<Corso>().HasData(
               new Corso
               {
                   Id = 1,
                   Nome ="Cristoforo Colombo",
                  AnnoAccademico = "2019-2021",
                  DataInizio = new DateTime (2019, 11, 03),
                  DataFine = new DateTime (2021, 07, 25),
                   Sede = "CASALECCHIO DI R.",
                   OrganizzatoreId = 3,
               },
                new Corso
                {
                    Id = 2,
                    Nome = "Alan Turing",
                    AnnoAccademico = "2019-2021",
                    DataInizio = new DateTime(2019, 10, 03),
                    DataFine = new DateTime(2021, 07, 14),
                    Sede = "CESENA",
                    OrganizzatoreId = 3,


                });

            
            builder.Entity<Modulo>().HasData(
                new Modulo
                {
                    Id = 3,
                    Nome = "PROGRAMMAZIONE CLOUD",
                    Materia = "CLOUD",
                    DataInizio = new DateTime(2021, 01, 08),
                    DataFine = new DateTime(2021, 05, 15),                    
                    DocenteId = 1,
                    TutorId = 2                    

                });
            


        }
    }
}
