using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGT.API.ApiModel
{
    public class VehiculoDto
    {
        public string Matricula { get; set; }
        public ICollection<VehiculoConductorDto> ConductoresHabituales { get; set; }
        public string NombreModelo { get; set; }
    }
}
