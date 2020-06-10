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
                    Cognome = "Fillonari",
                    NumTelefono = 123456,
                    Email = "sonoio@gmail.com",
                    DataAssunzione = DateTime.Now,
                    DataNascita = new DateTime(1984, 12, 07)


                });

            builder.Entity<Organizzatore>().HasData(
                new Organizzatore
                {
                    Id = 3,
                    Nome = "Mario",
                    Cognome = "Cadrega",
                    NumTelefono = 33516523,
                    Email = "caddy@gmail.com",
                    DataAssunzione = DateTime.Now,
                    DataNascita = new DateTime(1996, 04, 18)


                });



            builder.Entity<Partecipante>().HasData(
               new Partecipante
               {
                   Id = 3,
                   DataNascita = new DateTime(1974, 06, 15),
                   Citta = "Brisighella",
                   Nome = "Gisella",
                   Cognome = " Bianchi",
                   Email = "ecco@gmail.com",
                   Telefono = "3289632147",
                   AnnoDiploma = new DateTime(1994),
                   TipoDiploma = "Liceo Scientifico",
                   Indirizzo = "Via Stretta, 48"

               });

        }
    }
}
