using System;
using System.Collections.Generic;
using System.Text;

namespace DGT.Domain.Models
{
    public class CocheConductor
    {
        public Coche Coche { get; set; }
        public string Matricula { get; set; }

        public Conductor Conductor { get; set; }
        public string DNI { get; set; }
    }
}
