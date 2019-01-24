using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaReuniao.Dominio.Entities;
using SalaReuniao.Dominio.Contracts.Repositories;
using SalaReuniao.Dominio.Contracts.Services;
using SalaReuniao.Dominio.Specifications.Salas;
using SalaReuniao.Dominio.Exceptions.Salas;

namespace SalaReuniao.Dominio.Services
{
    public class SalaDomainService
        : BaseDomainService<Sala, int>, ISalaDomainService
    {
        private readonly IUnitOfWork unitOfWork;

        public SalaDomainService(IUnitOfWork unitOfWork)
            : base(unitOfWork.SalaRepository)
        {
            this.unitOfWork = unitOfWork;
        }

        public override void Inserir(Sala entity)
        {
            var salaComNomeIgual = new SalaNaoPodeTerOMesmoNomeDeOutraSalaSpecification(unitOfWork.SalaRepository);

            if (salaComNomeIgual.IsSatisfiedBy(entity))
            {
                base.Inserir(entity);
            }
            else
            {
                throw new SalaNaoPodeTerOMesmoNomeDeOutraSalaException(entity.Nome);
            }
        }

        public override void Atualizar(Sala entity)
        {
            var registro = unitOfWork.SalaRepository.FindById(entity.IdSala);

            if (registro != null)
            {
                var salaComNomeIgual = new SalaNaoPodeTerOMesmoNomeDeOutraSalaSpecification(unitOfWork.SalaRepository);

                if (salaComNomeIgual.IsSatisfiedBy(entity))
                {
                    registro.Nome = entity.Nome;
                    registro.Observacao = entity.Observacao;
                    registro.PossuiProjetor = entity.PossuiProjetor;
                    registro.PossuiQuadro = entity.PossuiQuadro;
                    registro.PossuiVideoConfer = entity.PossuiVideoConfer;
                    registro.Predio = entity.Predio;
                    registro.QtdCadeiras = entity.QtdCadeiras;
                    registro.Ramal = entity.Ramal;
                    registro.RamalResponsavel = entity.RamalResponsavel;
                    registro.UsuarioResponsavel = entity.UsuarioResponsavel;
                    registro.IdCidade = entity.IdCidade;
                    registro.IdEmpresa = entity.IdEmpresa;
                    registro.IdEstado = entity.IdEstado;                    

                    base.Atualizar(registro);
                }
                else
                {
                    throw new SalaNaoPodeTerOMesmoNomeDeOutraSalaException(entity.Nome);
                }
            }
            else
            {
                throw new Exception("Sala não encontrada.");
            }
        }
    }
}
