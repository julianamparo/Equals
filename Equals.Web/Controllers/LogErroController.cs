using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Equals.Dominio.Contratos;
using Equals.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Equals.Web.Controllers
{
    [Route("api/[Controller]")]
    public class LogErroController : Controller
    {
        private readonly ILogErroRepositorio _logErroRepositorio;
        public LogErroController(ILogErroRepositorio logErroRepositorio)
        {
            _logErroRepositorio = logErroRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<LogErro> erros = (List<LogErro>)_logErroRepositorio.ObterTodos();
                return Ok(erros);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost]
        public IActionResult Post([FromBody] LogErro logErro)
        {
            try
            {
                _logErroRepositorio.Adicionar(logErro);
                return Created("api/logErro", logErro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
