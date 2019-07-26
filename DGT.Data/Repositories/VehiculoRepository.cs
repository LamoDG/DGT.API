using DGT.Data.Abstract;
using DGT.Domain.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DGT.Data.Repositories
{
    public class VehiculoRespository : EntityBaseRepository<Vehiculo>, IVehiculoRespository
    {
        public VehiculoRespository(DGTContext context) : base(context)
        {

        }
    }
}
