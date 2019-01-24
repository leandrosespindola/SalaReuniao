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
    public class UsuarioDomainService : BaseDomainService<Usuario, int>, IUsuarioDomainService
    {
        private readonly IUnitOfWork unitOfWork;

        public UsuarioDomainService(IUnitOfWork unitOfWork)
            : base (unitOfWork.UsuarioRepository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
