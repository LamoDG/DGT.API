using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DGT.Domain.Models
{
   public class Infraccion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InfraccionId { get; set; }

        public Conductor Conductor { get; set; }
        [Required]
        public string DNI { get; set; }
        public Vehiculo Vehiculo { get; set; }
        [Required]
        public string Matricula { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        public TipoInfraccion TipoInfraccion { get; set; }
        [Required]
        public int TipoInfraccionId { get; set; }
    }
}
