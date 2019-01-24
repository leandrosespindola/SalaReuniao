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
    public class ParametroDomainService : BaseDomainService<Parametro, int>, IParametroDomainService
    {
        private readonly IUnitOfWork unitOfWork;

        public ParametroDomainService(IUnitOfWork unitOfWork)
            : base (unitOfWork.ParametroRepository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
