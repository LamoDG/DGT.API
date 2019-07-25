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
            modelBuilder.Entity<VehiculoConductor>().HasKey(cc => new { cc.Matricula, cc.DNI });
        }



        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Conductor> Conductores { get; set; }
        public DbSet<Infraccion> Infracciones { get; set; }
        public DbSet<MarcaVehiculo> MarcasVehiculo { get; set; }
        public DbSet<ModeloVehiculo> ModelosVehiculo { get; set; }
        public DbSet<TipoInfraccion> TiposInfraccion { get; set; }
    }
}
