using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Dominio.Contracts.Specifications
{
    public interface ISpecification<TEntity>
        where TEntity : class
    {
        bool IsSatisfiedBy(TEntity entity);
    }
}
