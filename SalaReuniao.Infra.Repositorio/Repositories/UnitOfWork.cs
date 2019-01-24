using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaReuniao.Dominio.Contracts.Repositories;
using SalaReuniao.Infra.Repositorio.Context;

namespace SalaReuniao.Infra.Repositorio.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext contexto;
        private DbContextTransaction transaction;

        public UnitOfWork(DataContext contexto)
        {
            this.contexto = contexto;
        }

        public void BeginTransaction()
        {
            transaction = contexto.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (transaction != null) transaction.Commit();
        }

        public void RollBack()
        {
            if (transaction != null) transaction.Rollback();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

        public ISalaRepository SalaRepository => new SalaRepository(contexto); 

        public IUsuarioRepository UsuarioRepository => new UsuarioRepository(contexto);

        public IAgendaRepository AgendaRepository => new AgendaRepository(contexto);

        public ICidadeRepository CidadeRepository => new CidadeRepository(contexto);

        public IEmpresaRepository EmpresaRepository => new EmpresaRepository(contexto);

        public IParametroRepository ParametroRepository => new ParametroRepository(contexto);

        public IEstadoRepository EstadoRepository => new EstadoRepository(contexto);
    }
}
