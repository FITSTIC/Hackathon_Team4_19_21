using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using prova1.Data;

namespace Fitstic_Hackathon_4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Personale> TabOperatori { get; set; }
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

            builder.Entity<Personale>().HasData(
                new Personale
                {
                    IdPers = 1,
                    Nome = "Mario",
                    Cognome = "Verdi",
                    NumTelefono = 123456,
                    Email = "sonobello@gmail.com",
                    DataAssunzione = DateTime.Now,
                    DataNascita = new DateTime(1980, 10, 5)
                    
                    
                });

            builder.Entity<Esame>().HasData(
               new Esame
               {
                   Data = new DateTime(2020, 06, 25),
                   IdEsame = 50,
                   IdModulo = 7,
                   IdPartecipante = 56,
                   Punteggio = 2                  
                   
               });

            builder.Entity<Partecipante>().HasData(
               new Partecipante
               {
                   IdPart = 56,
                   DataNascita = new DateTime(2000, 05, 25),
                   Citta = "Brisighella",
                   Nome = "Aldo",
                   Cognome = " Bianchi",
                   Email = "eccomi@gmail.com",
                   Telefono = "15874",
                   AnnoDiploma = new DateTime(2000),
                   TipoDiploma = "Tecnico Elettronico",
                   Indirizzo = "Via Larga, 45"
                                 
               });

        }

    
        
    }
}

