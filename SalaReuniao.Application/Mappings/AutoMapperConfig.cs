using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace SalaReuniao.Application.Mappings
{
    public class AutoMapperConfig
    {
        // Incluir no Global.asax no metodo Applicatoin_Start na camada de Apresentação.
        public static void Register()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<EntityToModelMap>();
                cfg.AddProfile<ModelToEntityMap>();
            });
        }

    }
}
