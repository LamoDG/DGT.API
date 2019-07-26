using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGT.API.ApiModel
{
    public class ConductorDto
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Puntos { get; set; }
    }
}
