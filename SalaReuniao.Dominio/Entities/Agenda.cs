using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Dominio.Entities
{
    public class Agenda
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
          
        public virtual DateTime DataAlteracaoRegistro { get; set; }
        public virtual int IdUsuarioAlteracao { get; set; }
     
        public virtual DateTime DataCancelamento { get; set; }
        public virtual int IdUsuarioCanc { get; set; }

        public virtual Sala Sala { get; set; }
        public virtual Usuario UsuarioSolicitante { get; set; }
        public virtual Usuario UsuarioAlteracao { get; set; }
        public virtual Usuario UsuarioCanc { get; set; }

    }
}
