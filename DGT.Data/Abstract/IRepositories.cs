using DGT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DGT.Data.Abstract
{
    public interface IConductorRespository : IEntityBaseRepository<Conductor>
    {

    }
    public interface IVehiculoRespository : IEntityBaseRepository<Vehiculo>
    {

    }
    public interface IInfraccionRespository : IEntityBaseRepository<Infraccion>
    {
        
    }
    public interface ITipoInfraccionRespository : IEntityBaseRepository<TipoInfraccion>
    {
        Task<IEnumerable<TipoInfraccion>> GetTopHabituales(int numRecords);
    }

}
