using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Dominio.Contracts.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void RollBack();

        ISalaRepository SalaRepository { get;  }
        IUsuarioRepository UsuarioRepository { get; }
        IAgendaRepository AgendaRepository { get; }
        ICidadeRepository CidadeRepository { get; }
        IEstadoRepository EstadoRepository { get; }
        IEmpresaRepository EmpresaRepository { get; }
        IParametroRepository ParametroRepository { get; }
    }
}
