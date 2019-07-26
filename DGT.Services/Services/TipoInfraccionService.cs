using DGT.Data.Abstract;
using DGT.Domain.Models;
using DGT.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DGT.Services.Services
{
    public class TipoInfraccionService : EntityBaseService, ITipoInfraccionService
    {

        public TipoInfraccionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public async Task Crear(TipoInfraccion tipoInfraccion)
        {
            _unitOfWork.Repository<ITipoInfraccionRespository>().Add(tipoInfraccion);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<TipoInfraccion>> GetAll()
        {
           return await _unitOfWork.Repository<ITipoInfraccionRespository>().GetAllAsync();
        }

        public async Task<IEnumerable<TipoInfraccion>> Top5InfraccionesHabituales()
        {
            return await _unitOfWork.Repository<ITipoInfraccionRespository>().GetTopHabituales(5);
        }
        public async Task<IEnumerable<TipoInfraccion>> TopInfraccionesHabituales(int numRecords)
        {
            return await _unitOfWork.Repository<ITipoInfraccionRespository>().GetTopHabituales(numRecords);
        }
    }
}
