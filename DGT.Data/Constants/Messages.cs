﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DGT.Data.Constants
{
    public class Messages
    {
        private const string YA_EXISTE_VAR = "ya existe";
        public class Vehiculo {
            public const string NO_EXISTE_CONDUCTOR = "No hemos encotrado ningún conductor con ese DNI";

            public static readonly string YA_EXISTE = $"El vehículo {YA_EXISTE_VAR}";
        }
        public class Conductor
        {            
            public static readonly string YA_EXISTE = $"El Conductor {YA_EXISTE_VAR}";
        }

    }
}
