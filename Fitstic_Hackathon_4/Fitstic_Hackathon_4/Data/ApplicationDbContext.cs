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
        public DbSet<Personale> Operatori { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
