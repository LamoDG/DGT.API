using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DGT.API.ApiModel
{
    public class TipoInfraccionDto
    {
        [Required]
        public string Descripccion { get; set; }
        [Required]
        public int Puntos { get; set; }
    }
}
