using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Application.ViewModels.Salas
{
    public class SalaCadastroViewModel
    {
        //public int IdSala { get; set; }

        [MaxLength(100, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "Informe o nome da Sala.")]
        public string Nome { get; set; }
        public string Ramal { get; set; }

        public bool PossuiVideoConfer { get; set; }
        public bool PossuiProjetor { get; set; }
        public bool PossuiQuadro { get; set; }
        public int QtdCadeiras { get; set; }
        
        [MaxLength(300, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        public string Endereco { get; set; }
        public string Predio { get; set; }
        public string Andar { get; set; }

        [Required(ErrorMessage = "Informe a Empresa.")]
        public int IdEmpresa { get; set; }

        [Required(ErrorMessage = "Informe o Estado.")]
        public int IdEstado { get; set; }

        [Required(ErrorMessage = "Informe a Cidade.")]
        public int IdCidade { get; set; }

        public int IdUsuarioResponsavel { get; set; }
        public string RamalResponsavel { get; set; }

        public string Observacao { get; set; }
    }
}
