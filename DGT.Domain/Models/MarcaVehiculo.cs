using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DGT.Domain.Models
{
    public class MarcaVehiculo
    {
        [Key]
        public string Nombre { get; set; }
        public ICollection<ModeloVehiculo> Modelos { get; set; }
    }
}
