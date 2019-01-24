using SalaReuniao.Dominio.Contracts.Repositories;
using SalaReuniao.Dominio.Contracts.Specifications;
using SalaReuniao.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Dominio.Specifications.Salas
{
    public class SalaNaoPodeTerOMesmoNomeDeOutraSalaSpecification
        : ISpecification<Sala>
    {
        private readonly ISalaRepository repository;

        public SalaNaoPodeTerOMesmoNomeDeOutraSalaSpecification(ISalaRepository repository)
        {
            this.repository = repository;
        }

        public bool IsSatisfiedBy(Sala entity)
        {
            return repository.Count(c => c.Nome == entity.Nome) == 0;
        }
    }
}
