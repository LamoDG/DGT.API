using DGT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DGT.Services.Abstract
{
    public interface IVehiculoService 
    {
        Task Crear(Vehiculo vehiculo);
    }
}
