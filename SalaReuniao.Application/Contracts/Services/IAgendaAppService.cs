using SalaReuniao.Application.ViewModels.Agendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Application.Contracts.Services
{
    public interface IAgendaAppService : IDisposable
    {
        void Inserir(AgendaCadastroViewModel entity);
        void Atualizar(AgendaEdicaoViewModel entity);
        void Excluir(int idAgenda);
        List<AgendaConsultaViewModel> Consultar();
        AgendaConsultaViewModel ObterPorId(int IdAgenda);
    }
}
