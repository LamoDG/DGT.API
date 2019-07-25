using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DGT.Domain.Models
{
    public class TipoInfraccion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string TipoInfraccionId { get; set; }
        public string Descripccion { get; set; }
        public int Puntos { get; set; }
    }
}
