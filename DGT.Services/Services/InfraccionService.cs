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
    public class InfraccionService : EntityBaseService, IInfraccionService
    {
        public InfraccionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public async Task Crear(Infraccion infraccion)
        {
            var vehiculo = (await _unitOfWork.Repository<IVehiculoRespository>().FindByIncludingAsync(v => v.Matricula.Equals(infraccion.Matricula), c => c.ConductoresHabituales)).FirstOrDefault();
            if (vehiculo != null)
            {
                var vehiculoConductorHabitual = vehiculo.ConductoresHabituales.First();
                var conductor = await _unitOfWork.Repository<IConductorRespository>().GetSingleAsync(vehiculoConductorHabitual.DNI);
                var tipoInfraccion = (await _unitOfWork.Repository<ITipoInfraccionRespository>().FindByAsync(inf => inf.TipoInfraccionId == infraccion.TipoInfraccionId)).FirstOrDefault();
                
                if (tipoInfraccion != null)
                {
                    if(tipoInfraccion.Puntos> conductor.Puntos)
                    {
                        conductor.Puntos = 0 ;
                    }
                    else
                    {
                        conductor.Puntos = conductor.Puntos - tipoInfraccion.Puntos;
                    }                  

                    _unitOfWork.Repository<IConductorRespository>().Update(conductor);
                    _unitOfWork.Repository<IInfraccionRespository>().Add(infraccion);
                    await _unitOfWork.SaveChangesAsync();
                }
                throw new LogicLayerException("No exite el tipo de infracción");
            }
            throw new LogicLayerException("No exite el vehiculo");
        }

        public async Task<IEnumerable<Infraccion>> InfraccionesConductor(string DNI)
        {
            return await _unitOfWork.Repository<IInfraccionRespository>().FindByIncludingAsync(inf => inf.Conductor.DNI.Equals(DNI), i => i.Conductor);
        }
    }
}
