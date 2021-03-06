﻿using SalaReuniao.Application.Contracts.Services;
using SalaReuniao.Application.ViewModels.Agendas;
using SalaReuniao.Presentation.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SalaReuniao.Presentation.Controllers
{
    [RoutePrefix("api/agenda")]
    public class AgendaController : ApiController
    {
        private readonly IAgendaAppService appService;

        public AgendaController(IAgendaAppService appService)
        {
            this.appService = appService;
        }

        [HttpPost]
        [Route("cadastrar")]
        public HttpResponseMessage Post(AgendaCadastroViewModel entity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    appService.Inserir(entity);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Forbidden, Util.ValidationUtil(ModelState));
            }
        }

        [HttpPut]
        [Route("edicao")]
        public HttpResponseMessage Put(AgendaEdicaoViewModel entity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    appService.Atualizar(entity);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Forbidden, Util.ValidationUtil(ModelState));
            }
        }

        [HttpDelete]
        [Route("excluir")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                appService.Excluir(id);

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message); // http 400
            }
        }

        [HttpGet]
        [Route("consultar")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, appService.Consultar());
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message); // http 400
            }
        }

        [HttpGet] //requisições GET         
        [Route("obter")] //URL: /api/cliente/obter?id={0}         
        public HttpResponseMessage Get(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK,
                    appService.ObterPorId(id)); //HTTP 200             
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, e.Message); //HTTP 400             
            }
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            appService.Dispose();
        }
    }
}
