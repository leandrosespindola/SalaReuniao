using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Dominio.Entities
{
    public class Usuario
    {
        public virtual int IdUsuario { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual string Email { get; set; }
        public virtual string Setor { get; set; }
        public virtual string Ramal { get; set; }
        public virtual bool IsSecretaria { get; set; }
        public virtual bool IsAdmin { get; set; }

        public virtual List<Agenda> AgendasSolic { get; set; }
        public virtual List<Agenda> AgendasAlteracao { get; set; }
        public virtual List<Agenda> AgendasCanc { get; set; }

        public virtual List<Sala> Salas { get; set; }

        public virtual List<Parametro> Parametros { get; set; }
    }
}
