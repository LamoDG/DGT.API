using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DGT.Domain.Models
{
   public class ModeloCoche
    {
        [Key]
        public string Nombre { get; set; }
        public MarcaCoche Marca { get; set; }
        public ICollection<Coche> Coches { get; set; }
    }
}
