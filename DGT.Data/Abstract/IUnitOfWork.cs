using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DGT.Data.Abstract
{
    public interface IUnitOfWork
    {
        T Repository<T>();
        Task SaveChangesAsync();
    }
}
