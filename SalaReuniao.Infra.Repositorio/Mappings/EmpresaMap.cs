using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SalaReuniao.Dominio.Entities;

namespace SalaReuniao.Infra.Repositorio.Mappings
{
    public class EmpresaMap : EntityTypeConfiguration<Empresa>
    {
        public EmpresaMap()
        {
            HasKey(e => e.IdEmpresa);

            Property(e => e.Nome)
                .HasMaxLength(400)
                .IsRequired();
        }
    }
}
