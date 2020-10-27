using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    [Route("api/Eventos/{action}")]
    public class EventosController : ApiController
    {

        [HttpGet]
        [ActionName("Get")]
        public IEnumerable<Evento> Get()
        {
            EventosRepository rep = new EventosRepository();
            List<Evento> lista = rep.Retrieve();
            return lista;
        }

        [HttpGet]
        [ActionName("GetDTO")]
        public IEnumerable<EventoDTO> GetDTO()
        {
            EventosRepository rep = new EventosRepository();
            List<EventoDTO> lista = rep.RetrieveDTO();
            return lista;
        }



        // GET: api/Eventos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Eventos
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Eventos/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {
        }
    }
}
