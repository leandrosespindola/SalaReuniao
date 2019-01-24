using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using SalaReuniao.Dominio.Entities;

namespace SalaReuniao.Infra.Repositorio.Mappings
{
    public class AgendaMap : EntityTypeConfiguration<Agenda>
    {
        public AgendaMap()
        {
            HasKey(a => a.IdAgenda);
            
            Property(a => a.DataHoraInicio)
                .IsRequired();

            Property(a => a.DataHoraFim)
                .IsRequired();

            Property(a => a.TempoDuracao)
                .HasMaxLength(20);

            Property(a => a.QtdParticipante);

            Property(a => a.QtdCafe);

            Property(a => a.QtdAgua);

            Property(a => a.DataCriacaoRegistro)
                .IsRequired();

            Property(a => a.DataAlteracaoRegistro);

            Property(a => a.DataCancelamento);
            
            //Property(a => a.IdSala).IsRequired();
            //Property(a => a.IdUsuarioSolic).IsRequired();
            //Property(a => a.IdUsuarioAlteracao);
            //Property(a => a.IdUsuarioCanc);
            
            HasRequired(a => a.Sala)
                .WithMany(s => s.Agenda)
                .HasForeignKey(a => a.IdSala);

            HasRequired(a => a.UsuarioSolicitante)
                .WithMany(u => u.AgendasSolic)
                .HasForeignKey(a => a.IdUsuarioSolic);

            HasRequired(a => a.UsuarioAlteracao)
                .WithMany(u => u.AgendasAlteracao)
                .HasForeignKey(a => a.IdUsuarioAlteracao);

            HasRequired(a => a.UsuarioCanc)
                .WithMany(u => u.AgendasCanc)
                .HasForeignKey(a => a.IdUsuarioCanc);
        }
    }
}
