using SalaReuniao.Application.Contracts.Services;
using SalaReuniao.Application.Mappings;
using SalaReuniao.Application.Services;
using SalaReuniao.Dominio.Contracts.Repositories;
using SalaReuniao.Dominio.Contracts.Services;
using SalaReuniao.Dominio.Services;
using SalaReuniao.Infra.Repositorio.Context;
using SalaReuniao.Infra.Repositorio.Repositories;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace SalaReuniao.Presentation
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            /************************************************************************************/
            GlobalConfiguration.Configure(WebApiConfig.Register);
            /************************************************************************************/
            AutoMapperConfig.Register();
            /************************************************************************************/
            // Create the container as usual. SimpleInjector
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            // Register your types, for instance using the scoped lifestyle:
            container.Register<ISalaRepository, SalaRepository>(Lifestyle.Scoped);
            container.Register<IAgendaRepository, AgendaRepository>(Lifestyle.Scoped);
            container.Register<ICidadeRepository, CidadeRepository>(Lifestyle.Scoped);
            container.Register<IEmpresaRepository, EmpresaRepository>(Lifestyle.Scoped);
            container.Register<IEstadoRepository, EstadoRepository>(Lifestyle.Scoped);
            container.Register<IParametroRepository, ParametroRepository>(Lifestyle.Scoped);
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);


            container.Register<ISalaAppService, SalaAppService>(Lifestyle.Scoped);
            container.Register<IAgendaAppService, AgendaAppService>(Lifestyle.Scoped);
            /* 
            container.Register<ICidadeAppService, CidadeAppService>(Lifestyle.Scoped);
            container.Register<IEmpresaAppService, EmpresaAppService>(Lifestyle.Scoped);
            container.Register<IEstadoAppService, EstadoAppService>(Lifestyle.Scoped);
            container.Register<IParametroAppService, ParametroAppService>(Lifestyle.Scoped);
            container.Register<IUsuarioAppService, UsuarioAppService>(Lifestyle.Scoped);
            */

            container.Register<ISalaDomainService, SalaDomainService>(Lifestyle.Scoped);
            container.Register<IAgendaDomainService, AgendaDomainService>(Lifestyle.Scoped);
            container.Register<ICidadeDomainService, CidadeDomainService>(Lifestyle.Scoped);
            container.Register<IEmpresaDomainService, EmpresaDomainService>(Lifestyle.Scoped);
            container.Register<IEstadoDomainService, EstadoDomainService>(Lifestyle.Scoped);
            container.Register<IParametroDomainService, ParametroDomainService>(Lifestyle.Scoped);
            container.Register<IUsuarioDomainService, UsuarioDomainService>(Lifestyle.Scoped);

            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<DataContext>(Lifestyle.Scoped);

            // This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
            /************************************************************************************/
        }

        // ver template de layout na pasta PROJETO
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");

            if (HttpContext.Current.Request.HttpMethod == "OPTIONS")
            {
                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");

                HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept");

                HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");

                HttpContext.Current.Response.End();
            }
        }
    }
}
