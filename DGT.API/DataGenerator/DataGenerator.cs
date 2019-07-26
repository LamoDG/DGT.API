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
            SeedMarcasVehiculo(context);
            SeedModeloVehiculo(context);
            SeedConductor(context);
            SeedTipoInfraccion(context);
            SeedVehiculo(context);
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
            context.SaveChanges();
        }

        private static void SeedModeloVehiculo(DGTContext context)
        {
            context.AddRange(
                new ModeloVehiculo
                {
                    Marca = context.MarcasVehiculo.First(),
                    Nombre = "Mustang",
                },
                new ModeloVehiculo
                {
                    Marca = context.MarcasVehiculo.First(),
                    Nombre = "Jimmy",
                },
                new ModeloVehiculo
                {
                    Marca = context.MarcasVehiculo.First(),
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

        private static void SeedVehiculo(DGTContext context)
        {

            context.AddRange(
                new Vehiculo
                {
                    Matricula = "7652GRH",
                    Modelo = context.ModelosVehiculo.First(),
                    ConductoresHabituales = new VehiculoConductor[] {
                        new VehiculoConductor {
                        DNI = "12341234R"
                    },
                        new VehiculoConductor{
                        DNI ="22223333X"
                        }
                    }
                },
                new Vehiculo
                {
                    Matricula = "5343BIH",
                    Modelo = context.ModelosVehiculo.Last(),
                    ConductoresHabituales = new VehiculoConductor[] {
                        new VehiculoConductor {
                        DNI = "43214321H"
                    }
                    }
                },//////
                new Vehiculo
                {
                    Matricula = "1343BIH",
                    Modelo = context.ModelosVehiculo.Last(),
                    ConductoresHabituales = new VehiculoConductor[] {
                        new VehiculoConductor {
                        DNI = "43214321H"
                    }
                    }
                },
                new Vehiculo
                {
                    Matricula = "2343BIH",
                    Modelo = context.ModelosVehiculo.Last(),
                    ConductoresHabituales = new VehiculoConductor[] {
                        new VehiculoConductor {
                        DNI = "43214321H"
                    }
                    }
                },
                new Vehiculo
                {
                    Matricula = "3343BIH",
                    Modelo = context.ModelosVehiculo.Last(),
                    ConductoresHabituales = new VehiculoConductor[] {
                        new VehiculoConductor {
                        DNI = "43214321H"
                    }
                    }
                },
                new Vehiculo
                {
                    Matricula = "4343BIH",
                    Modelo = context.ModelosVehiculo.Last(),
                    ConductoresHabituales = new VehiculoConductor[] {
                        new VehiculoConductor {
                        DNI = "43214321H"
                    }
                    }
                },
                new Vehiculo
                {
                    Matricula = "6343BIH",
                    Modelo = context.ModelosVehiculo.Last(),
                    ConductoresHabituales = new VehiculoConductor[] {
                        new VehiculoConductor {
                        DNI = "43214321H"
                    }
                    }
                },
                new Vehiculo
                {
                    Matricula = "7343BIH",
                    Modelo = context.ModelosVehiculo.Last(),
                    ConductoresHabituales = new VehiculoConductor[] {
                        new VehiculoConductor {
                        DNI = "43214321H"
                    }
                    }
                },
                new Vehiculo
                {
                    Matricula = "8343BIH",
                    Modelo = context.ModelosVehiculo.Last(),
                    ConductoresHabituales = new VehiculoConductor[] {
                        new VehiculoConductor {
                        DNI = "43214321H"
                    }
                    }
                },
                new Vehiculo
                {
                    Matricula = "9343BIH",
                    Modelo = context.ModelosVehiculo.Last(),
                    ConductoresHabituales = new VehiculoConductor[] {
                        new VehiculoConductor {
                        DNI = "43214321H"
                    }
                    }
                }
                );

            context.SaveChanges();
        }

        private static void SeedMarcasVehiculo(DGTContext context)
        {
            context.AddRange(
            new MarcaVehiculo() { Nombre = "Seat" },
            new MarcaVehiculo() { Nombre = "Ford" },
            new MarcaVehiculo() { Nombre = "Nissan" },
            new MarcaVehiculo() { Nombre = "Fiat" },
            new MarcaVehiculo() { Nombre = "Mazda" },
            new MarcaVehiculo() { Nombre = "Jaguar" }
            );

            context.SaveChanges();
        }
    }
}
