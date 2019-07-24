using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DGT.Domain.Models
{
    public class MarcaCoche
    {
        [Key]
        public string Nombre { get; set; }
        public List<ModeloCoche> Modelos { get; set; }
    }
}
