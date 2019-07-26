using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DGT.API.ApiModel
{
    public class VehiculoDto
    {
        [Required]
        public string Matricula { get; set; }
        [Required]
        public ICollection<VehiculoConductorDto> ConductoresHabituales { get; set; }
        [Required]
        public string NombreModelo { get; set; }
    }
}
