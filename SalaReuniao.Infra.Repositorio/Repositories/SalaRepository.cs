using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaReuniao.Infra.Repositorio.Context;
using SalaReuniao.Dominio.Entities;
using SalaReuniao.Dominio.Contracts.Repositories;

namespace SalaReuniao.Infra.Repositorio.Repositories
{
    public class SalaRepository
        : BaseRepository<Sala, int>, ISalaRepository
    {
        private readonly DataContext contexto;

        public SalaRepository(DataContext contexto)
            : base (contexto)
        {
            this.contexto = contexto;
        }
    }
}
