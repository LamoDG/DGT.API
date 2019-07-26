using DGT.Data.Abstract;
using DGT.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGT.Data.Repositories
{
    public class TipoInfraccionRepository:EntityBaseRepository<TipoInfraccion>, ITipoInfraccionRespository
    {
        public TipoInfraccionRepository(DGTContext context):base(context)
        {

        }
        public async Task<IEnumerable<TipoInfraccion>> GetTopHabituales(int numRecords)
        {             

            return await (from infrac in _context.Infracciones
                    group infrac by infrac.TipoInfraccion into groupInfrac
                    orderby groupInfrac.Count() ascending
                    select groupInfrac.Key).Take(numRecords).ToListAsync();
        }
    }
}
