using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DGT.Domain.Models
{
    public class Coche
    {
        [Key]
        public string Matricula { get; set; }
        public int Marca { get; set; }
        public Conductor ConductorHabitual { get; set; }
        public ICollection<Conductor> ConductoresHabituales { get; set; }
        public ModeloCoche Modelo { get; set; }
    }
}
