using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DGT.Domain.Models
{
   public class Infraccion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InfraccionId { get; set; }
        public Conductor Conductor { get; set; }
        public string DNI { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public string Matricula { get; set; }
        public DateTime Fecha { get; set; }
        public TipoInfraccion TipoInfraccion { get; set; }
        public int TipoInfraccionId { get; set; }
    }
}
