﻿using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    [Route("api/Mercados/{action}")]
    public class MercadosController : ApiController
    {
        [HttpGet]
        [ActionName("Get")]
        public IEnumerable<Mercado> Get()
        {
            MercadosRepository rep = new MercadosRepository();
            List<Mercado> lista = rep.Retrieve();
            return lista;
        }
        [HttpGet]
        [ActionName("GetDTO")]
        public IEnumerable<MercadoDTO2> GetDTO()
        {
            MercadosRepository rep = new MercadosRepository();
            List<MercadoDTO2> lista = rep.RetrieveDTO();
            return lista;
        }


        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Mercados
        public void Post([FromBody] Mercado m)
        {
            var repo = new MercadosRepository();
            repo.Save(m);
        }

        // PUT: api/Mercados/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mercados/5
        public void Delete(int id)
        {
        }
    }
}
