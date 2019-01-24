using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Dominio.Entities
{
    public class Sala
    {
        public virtual int IdSala { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Ramal { get; set; }
                
        public virtual bool PossuiVideoConfer { get; set; }
        public virtual bool PossuiProjetor { get; set; }
        public virtual bool PossuiQuadro { get; set; }
        public virtual int QtdCadeiras { get; set; }
   
        public virtual string Endereco { get; set; }
        public virtual string Predio { get; set; }
        public virtual string Andar { get; set; }
        public virtual int IdEmpresa { get; set; }
        public virtual int IdEstado { get; set; }
        public virtual int IdCidade { get; set; }
            
        public virtual int IdUsuarioResponsavel { get; set; }
        public virtual string RamalResponsavel { get; set; }

        public virtual string Observacao { get; set; }



        public virtual Cidade Cidade { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Usuario UsuarioResponsavel { get; set; }

        public virtual List<Agenda> Agenda { get; set; }

    }
}
