using DGT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DGT.Services.Abstract
{
    public interface ITipoInfraccionService
    {
        Task Crear(TipoInfraccion tipoInfraccion);
        Task<IEnumerable<TipoInfraccion>> Top5InfraccionesHabituales();
        Task<IEnumerable<TipoInfraccion>> GetAll();
    }
}
