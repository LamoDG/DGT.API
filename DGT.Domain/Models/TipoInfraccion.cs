﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DGT.Domain.Models
{
    public class TipoInfraccion
    {
        public string Identificador { get; set; }
        public string Descripccion { get; set; }
        public int Puntos { get; set; }
    }
}