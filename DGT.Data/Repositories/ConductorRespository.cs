using DGT.Data.Abstract;
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
     
    }
}
