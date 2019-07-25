using DGT.Data.Abstract;
using DGT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DGT.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IServiceProvider serviceProvider;
        private readonly DGTContext context;
        private bool disposed;
        private Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public UnitOfWork(IServiceProvider serviceProvider, DGTContext context)
        {
            this.serviceProvider = serviceProvider;
            this.context = context;
            this.disposed = false;
        }

        public T Repository<T>()
        {
            object repository;

            if (this.repositories.TryGetValue(typeof(T), out repository))
            {
                return (T)repository;
            }

            repository = this.serviceProvider.GetService(typeof(T));
            this.repositories.Add(typeof(T), repository);
            return (T)repository;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync()
        {
            await this.context.SaveChangesAsync();
        }
    }


}
