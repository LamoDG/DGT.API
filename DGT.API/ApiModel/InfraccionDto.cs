using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DGT.API.ApiModel
{
    public class InfraccionDto
    {
        [Required]
        public string Matricula { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public int TipoInfraccionId { get; set; }
    }
}
