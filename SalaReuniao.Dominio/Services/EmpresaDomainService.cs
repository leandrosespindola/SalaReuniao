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
    public class EmpresaDomainService
        : BaseDomainService<Empresa, int>, IEmpresaDomainService
    {
        private readonly IUnitOfWork unitOfWork;

        public EmpresaDomainService(IUnitOfWork unitOfWork)
            : base(unitOfWork.EmpresaRepository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
