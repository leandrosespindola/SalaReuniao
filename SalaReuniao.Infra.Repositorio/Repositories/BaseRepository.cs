using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaReuniao.Infra.Repositorio.Context;
using SalaReuniao.Dominio.Contracts.Repositories;
using System.Data.Entity;

namespace SalaReuniao.Infra.Repositorio.Repositories
{
    public abstract class BaseRepository<TEntity, TKey>
        : IBaseRepository<TEntity, TKey>
        where TEntity : class
    {
        private readonly DataContext contexto;

        public BaseRepository(DataContext contexto)
        {
            this.contexto = contexto;
        }

        public void Insert(TEntity entity)
        {
            contexto.Entry(entity).State = EntityState.Added;
            contexto.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            contexto.Entry(entity).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            contexto.Entry(entity).State = EntityState.Deleted;
            contexto.SaveChanges();
        }

        public List<TEntity> FindAll()
        {
            return contexto.Set<TEntity>().ToList();
        }

        public List<TEntity> FindAll(Func<TEntity, bool> where)
        {
            return contexto.Set<TEntity>().Where(where).ToList();
        }

        public TEntity FindById(TKey id)
        {
            return contexto.Set<TEntity>().Find(id);
        }

        public TEntity Find(Func<TEntity, bool> where)
        {
            return contexto.Set<TEntity>().SingleOrDefault(where);
        }

        public int Count()
        {
            return contexto.Set<TEntity>().Count();
        }

        public int Count(Func<TEntity, bool> where)
        {
            return contexto.Set<TEntity>().Count(where);
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
