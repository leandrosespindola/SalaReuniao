using SalaReuniao.Dominio.Contracts.Repositories;
using SalaReuniao.Dominio.Entities;
using SalaReuniao.Infra.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Infra.Repositorio.Repositories
{
    public class CidadeRepository : BaseRepository<Cidade, int>, ICidadeRepository
    {
        private readonly DataContext contexto;

        public CidadeRepository(DataContext contexto)
            : base(contexto)
        {
            this.contexto = contexto;
        }
    }
}
