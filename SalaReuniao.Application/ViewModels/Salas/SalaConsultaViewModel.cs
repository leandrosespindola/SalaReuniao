using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Application.ViewModels.Salas
{
    public class SalaConsultaViewModel
    {
        public int IdSala { get; set; }
        public string Nome { get; set; }
        public string Ramal { get; set; }

        public bool PossuiVideoConfer { get; set; }
        public bool PossuiProjetor { get; set; }
        public bool PossuiQuadro { get; set; }
        public int QtdCadeiras { get; set; }

        public string Endereco { get; set; }
        public string Predio { get; set; }
        public string Andar { get; set; }

        public int IdEmpresa { get; set; }

        public int IdEstado { get; set; }

        public int IdCidade { get; set; }

        public int IdUsuarioResponsavel { get; set; }
        public string RamalResponsavel { get; set; }

        public string Observacao { get; set; }
    }
}
