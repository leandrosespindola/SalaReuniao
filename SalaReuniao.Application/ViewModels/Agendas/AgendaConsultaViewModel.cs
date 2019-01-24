using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Application.ViewModels.Agendas
{
    public class AgendaConsultaViewModel
    {
        public virtual int IdAgenda { get; set; }

        public virtual int IdSala { get; set; }

        public virtual int IdUsuarioSolic { get; set; }

        public virtual DateTime DataHoraInicio { get; set; }

        public virtual DateTime DataHoraFim { get; set; }

        public virtual string TempoDuracao { get; set; }

        public virtual int QtdParticipante { get; set; }
        public virtual int QtdCafe { get; set; }
        public virtual int QtdAgua { get; set; }

        public virtual DateTime DataCriacaoRegistro { get; set; }
    }
}
