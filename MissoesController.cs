using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SpiderNetApi.Models;

namespace SpiderNetApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class MissoesController : ControllerBase
    {
        private static List<MissaoAranha> missoes = new();


        // ✅ GET
        [HttpGet]
        public ActionResult<IEnumerable<MissaoAranha>> Get()
        {
            return Ok(missoes);
        }


        // ✅ POST
        [HttpPost]
        public ActionResult<MissaoAranha> Post( MissaoAranha novaMissao)
        {
            missoes.Add(novaMissao);

            return Created("", novaMissao);
        }
    }
}


        
    
