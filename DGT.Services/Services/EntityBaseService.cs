using DGT.Data.Abstract;
using DGT.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DGT.Services.Services
{
    public class EntityBaseService: IEntityBaseService
    {
        protected readonly IUnitOfWork _unitOfWork;

        public EntityBaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }     
    }
}
