using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DGT.API.ApiModel
{
    public class ConductorDto
    {
        [Required]
        public string DNI { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public int Puntos { get; set; }
    }
}
