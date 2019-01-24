using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SalaReuniao.Dominio.Entities;

namespace SalaReuniao.Infra.Repositorio.Mappings
{
    public class SalaMap : EntityTypeConfiguration<Sala>
    {
        public SalaMap()
        {
            HasKey(s => s.IdSala);

            Property(s => s.Nome)
                .HasMaxLength(200)
                .IsRequired();

            Property(s => s.Ramal)
                .HasMaxLength(50);

            Property(s => s.Endereco)
                .HasMaxLength(400);

            Property(s => s.Predio)
                .HasMaxLength(100);

            Property(s => s.Andar)
                .HasMaxLength(10);

            Property(s => s.RamalResponsavel)
                .HasMaxLength(50);

            Property(s => s.PossuiVideoConfer);

            Property(s => s.PossuiProjetor);

            Property(s => s.PossuiQuadro);

            Property(s => s.QtdCadeiras);

            Property(s => s.Observacao)
                .HasMaxLength(1000);


            // Property(s => s.IdEmpresa).IsRequired();
            // Property(s => s.IdEstado);
            // Property(s => s.IdCidade);
            // Property(s => s.IdUsuarioResponsavel);

            HasRequired(s => s.Empresa)
                .WithMany(e => e.Salas)
                .HasForeignKey(s => s.IdEmpresa);

            HasRequired(s => s.Estado)
                .WithMany(e => e.Salas)
                .HasForeignKey(s => s.IdEstado);

            HasRequired(s => s.Cidade)
                .WithMany(c => c.Salas)
                .HasForeignKey(s => s.IdCidade);

            HasRequired(s => s.UsuarioResponsavel)
                .WithMany(u => u.Salas)
                .HasForeignKey(s => s.IdUsuarioResponsavel);
        }
    }
}
