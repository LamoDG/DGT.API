using System;
using System.Collections.Generic;
using System.Text;

namespace DGT.Domain.Models
{
    public class MarcaCoche
    {
        public string Nombre { get; set; }
        public List<ModeloCoche> Modelos { get; set; }
    }
}
