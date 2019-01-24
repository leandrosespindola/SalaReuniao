
using SalaReuniao.Application.ViewModels.Salas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Application.Contracts.Services
{
    public interface ISalaAppService : IDisposable
    {
        void Inserir(SalaCadastroViewModel entity);
        void Atualizar(SalaEdicaoViewModel entity);
        void Excluir(int idSala);
        List<SalaConsultaViewModel> Consultar();
        SalaConsultaViewModel ObterPorId(int idSala);
    }
}
