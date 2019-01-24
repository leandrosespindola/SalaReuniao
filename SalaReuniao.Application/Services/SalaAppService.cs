using AutoMapper;
using SalaReuniao.Application.Contracts.Services;
using SalaReuniao.Application.ViewModels.Salas;
using SalaReuniao.Dominio.Contracts.Services;
using SalaReuniao.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Application.Services
{
    public class SalaAppService : ISalaAppService
    {
        private readonly ISalaDomainService domainService;

        public SalaAppService(ISalaDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Inserir(SalaCadastroViewModel entity)
        {
            domainService.Inserir(Mapper.Map<Sala>(entity));
        }

        public void Atualizar(SalaEdicaoViewModel entity)
        {
            domainService.Atualizar(Mapper.Map<Sala>(entity));
        }

        public void Excluir(int idSala)
        {
            var s = domainService.ObterPorId(idSala);
            domainService.Excluir(s);
        }

        public List<SalaConsultaViewModel> Consultar()
        {
            return Mapper.Map<List<Sala>, List<SalaConsultaViewModel>>(domainService.ListarTodos());
        }

        public SalaConsultaViewModel ObterPorId(int idSala)
        {
            return Mapper.Map<SalaConsultaViewModel>(domainService.ObterPorId(idSala));
        }

        public void Dispose()
        {
            domainService.Dispose();
        }
    }
}
