using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaReuniao.Dominio.Entities;

namespace SalaReuniao.Dominio.Contracts.Repositories
{
    public interface IEstadoRepository : IBaseRepository<Estado, int>
    {
    }
}
