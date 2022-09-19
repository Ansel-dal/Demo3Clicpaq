using Demo3.Server.Context;
using Demo3.Shared.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo3.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuiaController : ControllerBase
    {
        // GET: api/<GuiaController>
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            
            Respuesta<Guium> oRespuesta = new ();

            try
            {
                using (CLPContext db = new CLPContext())
                {
                    var lst = db.Guia.
                        Where(x => x.Guia == id)
                        .First();
                    oRespuesta.Exito = 1;
                    oRespuesta.List = lst;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }
    }
}
