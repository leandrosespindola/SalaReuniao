using AutoMapper;
using SalaReuniao.Application.Contracts.Services;
using SalaReuniao.Application.ViewModels.Agendas;
using SalaReuniao.Dominio.Contracts.Services;
using SalaReuniao.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Application.Services
{
    public class AgendaAppService : IAgendaAppService
    {
        private readonly IAgendaDomainService domainService;

        public AgendaAppService(IAgendaDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Inserir(AgendaCadastroViewModel entity)
        {
            domainService.Inserir(Mapper.Map<Agenda>(entity));
        }

        public void Atualizar(AgendaEdicaoViewModel entity)
        {
            domainService.Atualizar(Mapper.Map<Agenda>(entity));
        }

        public void Excluir(int idAgenda)
        {
            var a = domainService.ObterPorId(idAgenda);
            domainService.Excluir(a);
        }

        public List<AgendaConsultaViewModel> Consultar()
        {
            return Mapper.Map<List<Agenda>, List<AgendaConsultaViewModel>>(domainService.ListarTodos());
        }

        public AgendaConsultaViewModel ObterPorId(int idAgenda)
        {
            return Mapper.Map<AgendaConsultaViewModel>(domainService.ObterPorId(idAgenda));
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}
