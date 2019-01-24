using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Dominio.Entities
{
    public class Estado
    {
        public virtual int IdEstado { get; set; }
        public virtual string Nome { get; set; }

        public virtual List<Cidade> Cidades { get; set; }
        public virtual List<Sala> Salas { get; set; }
    }
}
