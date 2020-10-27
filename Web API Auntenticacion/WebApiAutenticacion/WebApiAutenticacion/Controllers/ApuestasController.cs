using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI;
using PlaceMyBet.Models;

namespace PlaceMyBet.Controllers
{
    [Route("api/Apuestas/{action}")]
    public class ApuestasController : ApiController
    {
        [HttpGet]
        [ActionName("Get")]
        public IEnumerable<Apuesta> Get()
        {
            ApuestasRepository rep = new ApuestasRepository();
            List<Apuesta> lista = rep.Retrieve();
            return lista;
        }
        [HttpGet]
        [ActionName("GetDTO")]
        public IEnumerable<ApuestaDTO> GetDTO()
        {
            ApuestasRepository rep = new ApuestasRepository();
            List<ApuestaDTO> lista = rep.RetrieveDTO();
            return lista;
        }

        [Authorize(Roles="Admin")]
        public List<ApuestaDTO2> GetGmailTipoMercado(string g, double t)
        {
            var repo = new ApuestasRepository();
            List<ApuestaDTO2> lista = repo.RetrieveByEmailMercado(g, t);
            return lista;
        }
        [Authorize(Roles = "Admin")]
        public List<ApuestaDTO3> GetGmailIdMercado(string g, int i)
        {
            var repo = new ApuestasRepository();
            List<ApuestaDTO3> lista = repo.RetrieveByEmailIdMercado(g, i);
            return lista;
        }
        [Authorize]
        public void Post([FromBody] Apuesta a)
        {
            var repo = new ApuestasRepository();
            repo.Save(a);
        }

        // PUT: api/Apuestas/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Apuestas/5
        public void Delete(int id)
        {
        }
    }
}
