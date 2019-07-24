using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DGT.Domain.Models
{
   public class ModeloCoche
    {
        [Key]
        public int Nombre { get; set; }
        public MarcaCoche Marca { get; set; }
        public List<Coche> Coches { get; set; }
    }
}
