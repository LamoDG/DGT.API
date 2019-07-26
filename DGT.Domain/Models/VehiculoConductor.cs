using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DGT.Domain.Models
{
    public class VehiculoConductor
    {
        public Vehiculo Vehiculo { get; set; }
        [Required]
        public string Matricula { get; set; }

        public Conductor Conductor { get; set; }
        [Required]
        public string DNI { get; set; }
    }
}
