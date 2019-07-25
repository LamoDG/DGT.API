using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DGT.Domain.Models
{
    public class DGTContext : DbContext
    {
        public DGTContext(DbContextOptions<DGTContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CocheConductor>().HasKey(cc => new { cc.Matricula, cc.DNI });
        }



        public DbSet<Coche> Coches { get; set; }
        public DbSet<Conductor> Conductores { get; set; }
        public DbSet<Infraccion> Infracciones { get; set; }
        public DbSet<MarcaCoche> MarcasCoche { get; set; }
        public DbSet<ModeloCoche> ModelosCoche { get; set; }
        public DbSet<TipoInfraccion> TiposInfraccion { get; set; }
    }
}
