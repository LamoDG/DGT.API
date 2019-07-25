using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DGT.Domain.Models
{
    public class Conductor
    {
        [Key]
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Puntos { get; set; }
        public ICollection<VehiculoConductor> Vehiculo { get; set; }
    }
}
