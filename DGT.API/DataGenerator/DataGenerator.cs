using DGT.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGT.API.DataGenerator
{
    public class DataGenerator
    {

        public static void Initializa(IServiceProvider serviceProvider)
        {
            using (var context = new DGTContext(serviceProvider.GetRequiredService<DbContextOptions<DGTContext>>()))
            {
                Seed(context);
            }

        }



        private static void Seed(DGTContext context)
        {
            SeedMarcasCoches(context);
            SeedModeloCoche(context);
            SeedConductor(context);
            SeedTipoInfraccion(context);        
            SeedCoches(context);
        }

      

        private static void SeedConductor(DGTContext context)
        {
            context.Conductores.AddRange(
                new Conductor
                {
                    Apellidos = "Frontera Luna",
                    DNI = "43214321H",
                    Nombre = "Pere",
                    Puntos = 10
                },
                new Conductor
                {
                    Apellidos = "Solivellas Estrany",
                    DNI = "22223333X",
                    Nombre = "Jaume",
                    Puntos = 10
                },
                new Conductor
                {
                    Apellidos = "Busquets Pastor",
                    DNI = "12341234R",
                    Nombre = "Míriam",
                    Puntos = 10
                }
                );
        }

        private static void SeedModeloCoche(DGTContext context)
        {
            context.AddRange(
                new ModeloCoche
                {
                    Marca = context.MarcasCoche.First(),
                    Nombre = "Mustang",
                },
                new ModeloCoche
                {
                    Marca = context.MarcasCoche.First(),
                    Nombre = "Jimmy",
                },
                new ModeloCoche
                {
                    Marca = context.MarcasCoche.First(),
                    Nombre = "Jedi",
                });

            context.SaveChanges();
        }

        private static void SeedTipoInfraccion(DGTContext context)
        {
            context.TiposInfraccion.AddRange(
                new TipoInfraccion
                {
                    Descripccion = "Saltar Stop",
                    Puntos = 2,
                },
                     new TipoInfraccion
                     {
                         Descripccion = "Alcoholemia",
                         Puntos = 5,
                     }
                );

            context.SaveChanges();
        }

        private static void SeedCoches(DGTContext context)
        {
           
            context.AddRange(
                new Coche
                {
                    Matricula = "7652GRH",
                    Modelo = context.ModelosCoche.First(),
                    ConductoresHabituales = new CocheConductor[] {
                        new CocheConductor {
                        DNI = "12341234R"
                    },
                        new CocheConductor{
                        DNI ="22223333X"
                        }
                    }
                },
                new Coche
                {
                    Matricula = "5343BIH",
                    Modelo = context.ModelosCoche.Last(),
                    ConductoresHabituales = new CocheConductor[] {
                        new CocheConductor {
                        DNI = "43214321H"
                    }
                    }
                }
                );
            
            context.SaveChanges();
        }

        private static void SeedMarcasCoches(DGTContext context)
        {
            context.AddRange(
            new MarcaCoche() { Nombre = "Seat" },
            new MarcaCoche() { Nombre = "Ford" },
            new MarcaCoche() { Nombre = "Nissan" },
            new MarcaCoche() { Nombre = "Fiat" },
            new MarcaCoche() { Nombre = "Mazda" },
            new MarcaCoche() { Nombre = "Jaguar" }
            );

            context.SaveChanges();
        }
    }
}
