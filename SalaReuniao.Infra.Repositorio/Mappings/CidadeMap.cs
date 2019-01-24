using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SalaReuniao.Dominio.Entities;

namespace SalaReuniao.Infra.Repositorio.Mappings
{
    public class CidadeMap : EntityTypeConfiguration<Cidade>
    {
        public CidadeMap()
        {
            HasKey(c => c.IdCidade);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            HasRequired(c => c.Estado)
                .WithMany(e => e.Cidades)
                .HasForeignKey(c => c.IdEstado);
        }
    }
}
