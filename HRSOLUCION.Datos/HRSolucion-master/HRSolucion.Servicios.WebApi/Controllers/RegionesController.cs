using HRSolucion.Datos.EF.Repositorios;
using HRSolucion.Dominio.Entidades;
using HRSolucion.Dominio.Repositorios;
using HRSolucion.Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace HRSolucion.Servicios.WebApi.Controllers
{
    public class RegionesController : ApiController
    {
        [Route("regiones")]
        [HttpGet]
        public IQueryable<dtoRegion> ObtenerTodasRegiones()
        {
            IRepositorio<Region> repositorio = new RepositorioGenerico<Region>();
            var regiones = from r in repositorio.Listar()
                           select new dtoRegion() { 
                               IDRegion= r.IDRegion, NombreRegion = r.NombreRegion
                           };
            return regiones;
        }
        [Route("regiones/{ai_cod_region:int}")]
        [HttpGet]
        public IHttpActionResult ObtenerRegionPorCodigo(int ai_cod_region)
        {
            try
            {
                IRepositorio<Region> repositorio = new RepositorioGenerico<Region>();
                Region lo_region = repositorio.ObtenerPorCodigo(ai_cod_region);
                dtoRegion region = new dtoRegion() { IDRegion = lo_region.IDRegion, NombreRegion = lo_region.NombreRegion };
                if (region == null) return Ok(new Region() { IDRegion = ai_cod_region, NombreRegion="ERROR" } ); //return NotFound();
                return Ok(region);

            }
            catch (Exception le_excepcion)
            {
                //var errorMessagError = new HttpError(le_excepcion.Message) { { "ErrorCode", 405 } };
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent("Contenido: "),// + le_excepcion.Message),
                    ReasonPhrase = "Razon: " + (string.IsNullOrEmpty(le_excepcion.Message) ? le_excepcion.HResult.ToString() : le_excepcion.Message)
                });
                /*throw new HttpResponseException
                   (ControllerContext.Request.CreateErrorResponse(HttpStatusCode.MethodNotAllowed, le_excepcion.Message));//+ "-" + le_excepcion.InnerException.Message));// errorMessagError));*/
            }
        }
        //[ResponseType(typeof(BookDetailDTO))]
        //[Route("region/{ai_cod_region:int}")]
        //[HttpGet]
        //public async Task<IHttpActionResult> ObtenerRegionPorCodigoAsincrono(int ai_cod_region)
        //{
        //    dtoRegion region = null;
        //    using (var lo_contexto = new HRSolucion.Datos.EF.Contextos.HRContexto("HRcnx"))
        //    {
        //        region = await lo_contexto.Regiones.Select(r =>
        //            new dtoRegion()
        //            {
        //                IDRegion = r.IDRegion,
        //                NombreRegion = r.NombreRegion
        //            }).SingleOrDefaultAsync(r => r.IDRegion == ai_cod_region);
        //    }
        //    //IRepositorio<Region> repositorio = new RepositorioGenerico<Region>();
        //    //var region = await repositorio.Listar().Select(r =>
        //    //    new dtoRegion() 
        //    //    { 
        //    //        IDRegion = r.IDRegion, NombreRegion = r.NombreRegion
        //    //    }).SingleOrDefaultAsync();
        //    if (region == null) return NotFound();
        //    return Ok(region);
        //}
        public HttpResponseMessage Post(Region region)
        {
            if (ModelState.IsValid)
            {
                IRepositorio<Region> repositorio = new RepositorioGenerico<Region>();
                repositorio.Adicionar(region);
                repositorio.GuardarCambios();
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, region);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = region.IDRegion }));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }
    }
}
