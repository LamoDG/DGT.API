using System;
using System.Collections.Generic;
using System.Text;

namespace DGT.Domain.Models
{
   public class Infraccion
    {
        public int InfraccionId { get; set; }
        public Conductor Conductor { get; set; }
        public Coche Coche { get; set; }
        public DateTime Fecha { get; set; }
        public TipoInfraccion TipoInfraccion { get; set; }
    }
}
