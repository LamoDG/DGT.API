using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DGT.Domain.Models
{
   public class ModeloVehiculo
    {
        [Key]
        public string Nombre { get; set; }
        [Required]
        public MarcaVehiculo Marca { get; set; }
        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
