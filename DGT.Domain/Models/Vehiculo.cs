using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DGT.Domain.Models
{
    public class Vehiculo
    {
        [Key]
        public string Matricula { get; set; }
        public ICollection<VehiculoConductor> ConductoresHabituales { get; set; }
        public ModeloVehiculo Modelo { get; set; }
    }
}
