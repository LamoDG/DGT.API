using DGT.Data.Abstract;
using DGT.Domain.Models;
using DGT.Services.Abstract;
using DGT.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DGT.Services.Services
{
    public class ConductorService : EntityBaseService,IConductorService
    {
    
        public ConductorService(IUnitOfWork unitOfWork):base(unitOfWork)
        {
      
        }
        public async Task Crear(Conductor conductor)
        {
            if (PodemosCrearConductor(conductor))
            {
                _unitOfWork.Repository<IConductorRespository>().Add(conductor);
                await _unitOfWork.SaveChangesAsync();
            }
            else
            {
                throw new LogicLayerException(Constants.Messages.Conductor.YA_EXISTE);
            }
        }   

        public async Task<IEnumerable<Conductor>> Top(int numRegistros)
        {
            return await _unitOfWork.Repository<IConductorRespository>().TopAsync(numRegistros);
        }

        #region private
     
        private bool PodemosCrearConductor(Conductor conductor)
        {
            return ( _unitOfWork.Repository<IConductorRespository>().GetSingleAsync(cond => cond.DNI.Equals(conductor.DNI))) == null;

        }
        #endregion
        
    }
}
