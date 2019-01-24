using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Dominio.Contracts.Repositories
{
    public interface IBaseRepository<TEntity, TKey> : IDisposable
        where TEntity : class
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        List<TEntity> FindAll();
        List<TEntity> FindAll(Func<TEntity, bool> where);

        TEntity FindById(TKey id);
        TEntity Find(Func<TEntity, bool> where);

        int Count();
        int Count(Func<TEntity, bool> where);

    }
}
