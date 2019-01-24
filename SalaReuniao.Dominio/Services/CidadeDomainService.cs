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
    public class CidadeDomainService
        : BaseDomainService<Cidade, int>, ICidadeDomainService
    {
        private readonly IUnitOfWork unitOfWork;

        public CidadeDomainService(IUnitOfWork unitOfWork)
            : base(unitOfWork.CidadeRepository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
