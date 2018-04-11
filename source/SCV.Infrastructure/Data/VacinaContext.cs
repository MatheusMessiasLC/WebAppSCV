using Microsoft.EntityFrameworkCore;
using SCV.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCV.Infrastructure.Data
{
    public class VacinaContext : DbContext
    {
        public VacinaContext(DbContextOptions<VacinaContext> options) : base(options)
        {

        }
        public DbSet<Vacina> Vacinas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vacina>().ToTable("Tb_Vacina");
        }
    }
}
