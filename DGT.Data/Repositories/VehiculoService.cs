using DGT.Data.Abstract;
using DGT.Domain.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DGT.Data.Repositories.Exceptions;

namespace DGT.Data.Repositories
{
    public class VehiculoRespository : EntityBaseRepository<Vehiculo>, IVehiculoRespository
    {
        public VehiculoRespository(DGTContext context) : base(context)
        {

        }
        public override void Add(Vehiculo vehiculo)
        {
            if (PodemosAgregarVehiculo(vehiculo))
            {
                base.Add(vehiculo);
            }
        }

        private int GetNumeroVehiculosAsociados(Vehiculo vehiculo)
        {
            return _context.Conductores
                 .Where(cond => cond.DNI == vehiculo.ConductoresHabituales.First().DNI)
                 .Include(cond => cond.Vehiculo).FirstOrDefault().Vehiculo.Count;
        }

        /// <summary>
        /// Comprueba que se cumplan las restricciones
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        private bool PodemosAgregarVehiculo(Vehiculo vehiculo)
        {
            if (_context.Conductores.Any(cond => cond.DNI == vehiculo.ConductoresHabituales.First().DNI))
            {
                if (!_context.Vehiculo.Any(veh =>veh.Matricula.Equals(vehiculo.Matricula)))
                {
                    return GetNumeroVehiculosAsociados(vehiculo) <= Constants.Parameters.NUM_MAX_VEHÍCULOS_HABITUALES;
                }
                throw new DataLayerException(Constants.Messages.Vehiculo.YA_EXISTE);
            }
            throw new DataLayerException(Constants.Messages.Vehiculo.NO_EXISTE_CONDUCTOR);
        }
    }
}
