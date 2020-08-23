 using Equals.Dominio.Contratos;
using Equals.Dominio.Entidades;
using Equals.Repositorio.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Equals.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ArquivoController : Controller
    {
        private readonly IArquivoRepositorio _arquivoRepositorio;
        public ArquivoController(IArquivoRepositorio arquivoRepositorio)
        {
            _arquivoRepositorio = arquivoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Arquivo> arquivos = (List<Arquivo>)_arquivoRepositorio.ObterTodos();
                return Ok(arquivos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        [HttpPost]
        public IActionResult Post([FromBody]Arquivo arquivo)
        {
            try
            {
                _arquivoRepositorio.Adicionar(arquivo);
                return Created("api/arquivo", arquivo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
