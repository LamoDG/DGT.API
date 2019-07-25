using DGT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DGT.Data.Repositories
{
    public class InfraccionesRepository: EntityBaseRepository<InfraccionesRepository>,IInfraccionesRepository
    {
        public InfraccionesRepository(DGTContext context): base (context)
        {

        }
    }
}
