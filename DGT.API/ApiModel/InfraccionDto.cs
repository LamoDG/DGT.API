using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGT.API.ApiModel
{
    public class InfraccionDto
    {       
        public string Matricula { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoInfraccionId { get; set; }
    }
}
