using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaReuniao.Dominio.Contracts.Services;
using SalaReuniao.Dominio.Contracts.Repositories;

namespace SalaReuniao.Dominio.Services
{
    public abstract class BaseDomainService<TEntity, TKey>
        : IBaseDomainService<TEntity, TKey>
        where TEntity : class
    {
        private readonly IBaseRepository<TEntity, TKey> repository;

        protected BaseDomainService(IBaseRepository<TEntity, TKey> repository)
        {
            this.repository = repository;
        }

        public virtual void Inserir(TEntity entity)
        {
            repository.Insert(entity);
        }

        public virtual void Atualizar(TEntity entity)
        {
            repository.Update(entity);
        }

        public virtual void Excluir(TEntity entity)
        {
            repository.Delete(entity);
        }

        public virtual List<TEntity> ListarTodos()
        {
            return repository.FindAll();
        }

        public virtual TEntity ObterPorId(TKey id)
        {
            return repository.FindById(id);
        }

        public virtual void Dispose()
        {
            repository.Dispose();
        }
    }
}
