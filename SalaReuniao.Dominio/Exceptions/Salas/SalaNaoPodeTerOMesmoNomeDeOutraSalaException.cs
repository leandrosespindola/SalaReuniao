using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Dominio.Exceptions.Salas
{
    public class SalaNaoPodeTerOMesmoNomeDeOutraSalaException
        : Exception
    {
        private string nome;

        public SalaNaoPodeTerOMesmoNomeDeOutraSalaException(string nome)
        {
            this.nome = nome;
        }

        public override string Message => $"Sala não pode ter o mesmo nome( {nome} ) de outra sala.";
    }
}
