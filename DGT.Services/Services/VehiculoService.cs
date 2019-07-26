using DGT.Data.Abstract;
using DGT.Domain.Models;
using DGT.Services.Abstract;
using DGT.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGT.Services.Services
{
    public class VehiculoService : EntityBaseService, IVehiculoService
    {

        public VehiculoService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public async Task Crear(Vehiculo vehiculo)
        {
            if (await PodemosAgregarVehiculo(vehiculo))
            {
                _unitOfWork.Repository<IVehiculoRespository>().Add(vehiculo);
               await _unitOfWork.SaveChangesAsync();
            }

        }

        private async Task<int> GetNumeroVehiculosAsociados(Vehiculo vehiculo)
        {
            var numtotalCoches = (await _unitOfWork.Repository<IConductorRespository>().FindByIncludingAsync(cond => cond.DNI == vehiculo.ConductoresHabituales.First().DNI, i => i.Vehiculo)).FirstOrDefault().Vehiculo.Count;
            return numtotalCoches;
        }

        /// <summary>
        /// Comprueba que se cumplan las restricciones de un numero máximo de vehiculos habituales. En este caso concreto 10
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        private async Task<bool> PodemosAgregarVehiculo(Vehiculo vehiculo)
        {
            if ((await _unitOfWork.Repository<IConductorRespository>().Any(cond => cond.DNI == vehiculo.ConductoresHabituales.First().DNI)))
            {
                if (!await _unitOfWork.Repository<IVehiculoRespository>().Any(veh => veh.Matricula.Equals(vehiculo.Matricula)))
                {
                    if (await GetNumeroVehiculosAsociados(vehiculo) <= Constants.Parameters.NUM_MAX_VEHICULOS_HABITUALES)
                    {
                        return true;
                    }
                    throw new LogicLayerException(Constants.Messages.Conductor.MAX_COCHES_POR_CONDUTOR);
                }
                throw new LogicLayerException(Constants.Messages.Vehiculo.YA_EXISTE);
            }
            throw new LogicLayerException(Constants.Messages.Vehiculo.NO_EXISTE_CONDUCTOR);
        }
    }
}
