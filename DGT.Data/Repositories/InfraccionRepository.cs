using DGT.Data.Abstract;
using DGT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DGT.Data.Repositories
{
    public class InfraccionRepository: EntityBaseRepository<Infraccion>,IInfraccionRespository
    {
        public InfraccionRepository(DGTContext context): base (context)
        {

        }

   
    }
}
