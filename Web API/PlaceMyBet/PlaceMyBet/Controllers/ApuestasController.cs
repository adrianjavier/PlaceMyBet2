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
    [Route("api/Apuestas")]
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
        [Route("api/Apuestas/GetDTO")]
        public IEnumerable<ApuestaDTO2> GetDTO()
        {
            ApuestasRepository rep = new ApuestasRepository();
            List<ApuestaDTO2> lista = rep.RetrieveDTO();
            return lista;
        }

        //Nuevo examen
        [Route("api/Apuestas")]
        public List<ApuestaDTO4> Get(int dinero)
        {
            ApuestasRepository rep = new ApuestasRepository();
            return rep.RetrievebyId(dinero);
        }

        public void Post([FromBody]Apuesta a)
        {
            var repo = new ApuestasRepository();
            repo.Save(a);
        }

        // PUT: api/Apuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuestas/5
        public void Delete(int id)
        {
        }
    }
}
