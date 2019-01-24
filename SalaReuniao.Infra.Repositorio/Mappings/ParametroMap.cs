using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SalaReuniao.Dominio.Entities;

namespace SalaReuniao.Infra.Repositorio.Mappings
{
    public class ParametroMap : EntityTypeConfiguration<Parametro>
    {
        public ParametroMap()
        {
            HasKey(p => p.IdParametro);

            Property(p => p.Codigo);

            Property(p => p.Descricao)
                .HasMaxLength(150)
                .IsRequired();

            Property(p => p.Valor)
                .HasMaxLength(50)
                .IsRequired();
            
            Property(p => p.Obaservacao)
                 .HasMaxLength(50);

            Property(p => p.DataCriacaoRegistro);

            //Property(p => p.IdUsuarioCadastro);

            HasRequired(p => p.Usuario)
                .WithMany(u => u.Parametros)
                .HasForeignKey(p => p.IdUsuarioCadastro);
        }
    }
}
