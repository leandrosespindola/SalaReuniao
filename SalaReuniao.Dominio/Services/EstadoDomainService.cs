using SalaReuniao.Dominio.Contracts.Repositories;
using SalaReuniao.Dominio.Contracts.Services;
using SalaReuniao.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Dominio.Services
{
    public class EstadoDomainService : BaseDomainService<Estado, int>, IEstadoDomainService
    {
        private readonly IUnitOfWork unitOfWork;

        public EstadoDomainService(IUnitOfWork unitOfWork)
            : base(unitOfWork.EstadoRepository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
