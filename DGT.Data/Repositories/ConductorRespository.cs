using DGT.Data.Abstract;
using DGT.Data.Repositories.Exceptions;
using DGT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DGT.Data.Repositories
{
  public  class ConductorRespository : EntityBaseRepository<Conductor>,IConductorRespository
    {
        public ConductorRespository(DGTContext context):base(context)
        {

        }
        public override void Add(Conductor conductor)
        {
            if (!_context.Conductores.Any(con => con.DNI == conductor.DNI))
            {
                base.Add(conductor);
            }

            throw new DataLayerException(Constants.Messages.Conductor.YA_EXISTE);
        }
    }
}
