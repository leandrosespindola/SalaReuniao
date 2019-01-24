using SalaReuniao.Dominio.Contracts.Repositories;
using SalaReuniao.Dominio.Contracts.Services;
using SalaReuniao.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Dominio.Services
{
    public class AgendaDomainService 
        : BaseDomainService<Agenda, int>, IAgendaDomainService
        
    {
        private readonly IUnitOfWork unitOfWork;

        public AgendaDomainService(IUnitOfWork unitOfWork)
            : base (unitOfWork.AgendaRepository)
        {
            this.unitOfWork = unitOfWork;
        }

        public override void Inserir(Agenda entity)
        {
            base.Inserir(entity);
        }

        public override void Atualizar(Agenda entity)
        {
            var registro = unitOfWork.AgendaRepository.FindById(entity.IdAgenda);

            if (registro != null)
            {
                registro.DataHoraFim = entity.DataHoraFim;
                registro.DataHoraInicio = entity.DataHoraInicio;
                registro.IdSala = entity.IdSala;
                registro.IdUsuarioAlteracao = entity.IdUsuarioAlteracao;
                registro.IdUsuarioSolic = entity.IdUsuarioSolic;
                registro.QtdAgua = entity.QtdAgua;
                registro.QtdCafe = entity.QtdCafe;
                registro.QtdParticipante = entity.QtdParticipante;
                registro.TempoDuracao = entity.TempoDuracao;
                registro.UsuarioAlteracao = entity.UsuarioAlteracao;
                registro.DataAlteracaoRegistro = entity.DataAlteracaoRegistro;

                base.Atualizar(registro);
            }
            else
            {
                throw new Exception("O Agendamento não foi encontrado.");
            }
        }
    }
}
