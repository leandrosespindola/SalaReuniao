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
    public class AgendaRepository : BaseRepository<Agenda, int>, IAgendaRepository
    {
        private readonly DataContext contexto;

        public AgendaRepository(DataContext contexto) : base(contexto)
        {
            this.contexto = contexto;
        }
    }
}
