using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SalaReuniao.Dominio.Entities;

namespace SalaReuniao.Infra.Repositorio.Mappings
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            HasKey(u => u.IdUsuario);

            Property(u => u.Nome)
                .HasMaxLength(100)
                .IsRequired();

            Property(u => u.Login)
                .HasMaxLength(100)
                .IsRequired();

            Property(u => u.Senha)
                .HasMaxLength(15)
                .IsRequired();

            Property(u => u.Email)
                .HasMaxLength(100)
                .IsRequired();

            Property(u => u.Setor)
                .HasMaxLength(100)
                .IsRequired();

            Property(u => u.Ramal)
                .HasMaxLength(100)
                .IsRequired();

            Property(u => u.IsSecretaria)
                .IsRequired();

            Property(u => u.IsAdmin)
                .IsRequired();

        }

    }
}
