using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Application.ViewModels.Agendas
{
    public class AgendaCadastroViewModel
    {
        // public virtual int IdAgenda { get; set; }
        
        [MaxLength(100, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "Informe a Sala.")]
        public virtual int IdSala { get; set; }

        public virtual int IdUsuarioSolic { get; set; }

        [Required(ErrorMessage = "Informe a Data e Hora de Início.")]
        public virtual DateTime DataHoraInicio { get; set; }

        [Required(ErrorMessage = "Informe a Data e Hora de Fim.")]
        public virtual DateTime DataHoraFim { get; set; }

        public virtual string TempoDuracao { get; set; }

        [Required(ErrorMessage = "Informe a Sala.")]
        public virtual int QtdParticipante { get; set; }
        public virtual int QtdCafe { get; set; }
        public virtual int QtdAgua { get; set; }

        public virtual DateTime DataCriacaoRegistro { get; set; }
    }
}
