using AutoMapper;
using SalaReuniao.Application.ViewModels.Agendas;
using SalaReuniao.Application.ViewModels.Salas;
using SalaReuniao.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaReuniao.Application.Mappings
{
    public class ModelToEntityMap : Profile
    {
        public ModelToEntityMap()
        {
            CreateMap<SalaCadastroViewModel, Sala>();
            CreateMap<SalaEdicaoViewModel, Sala>();

            CreateMap<AgendaCadastroViewModel, Agenda>();
            CreateMap<AgendaEdicaoViewModel, Agenda>();

        }

    }
}
