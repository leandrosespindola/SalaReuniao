using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Dominio.Contracts.Services
{
    public interface IBaseDomainService<TEntity, TKey> : IDisposable
        where TEntity : class
    {
        void Inserir(TEntity entity);
        void Atualizar(TEntity entity);
        void Excluir(TEntity entity);

        List<TEntity> ListarTodos();
        TEntity ObterPorId(TKey id);
    }
}
