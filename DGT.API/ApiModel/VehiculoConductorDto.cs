using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DGT.API.ApiModel
{
    public class VehiculoConductorDto
    {
        [Required]
        public string Matricula;
        [Required]
        public string DNI;

    }
}
