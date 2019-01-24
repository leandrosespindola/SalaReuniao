using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Dominio.Entities
{
    public class Parametro
    {
        public virtual int IdParametro { get; set; }
        public virtual int Codigo { get; set; }
        public virtual string Descricao { get; set; }
        public virtual string Valor { get; set; }
        public virtual string Obaservacao { get; set; }
        public virtual DateTime DataCriacaoRegistro { get; set; }
        public virtual int IdUsuarioCadastro { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
