using DGT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DGT.Services.Abstract
{
    public interface IConductorService 
    {
        Task Crear(Conductor conductor);

        Task<IEnumerable<Conductor>> Top(int numRegistros);
    }
}
