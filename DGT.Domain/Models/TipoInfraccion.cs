using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DGT.Domain.Models
{
    public class TipoInfraccion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TipoInfraccionId { get; set; }
        [Required]
        public string Descripccion { get; set; }
        [Required]
        public int Puntos { get; set; }
    }
}
