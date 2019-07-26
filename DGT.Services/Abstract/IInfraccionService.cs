using DGT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DGT.Services.Abstract
{
    public interface IInfraccionService
    {
        Task Crear(Infraccion infraccion);
        Task<IEnumerable<Infraccion>> InfraccionesConductor(string DNI);
    }
}
