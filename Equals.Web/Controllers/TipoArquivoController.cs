using Equals.Dominio.Contratos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Equals.Web.Controllers
{
    [Route("api/[Controller]")]
    public class TipoArquivoController : Controller
    {     
            private readonly ITipoArquivoRepositorio _tipoArquivoRepositorio;
            public TipoArquivoController(ITipoArquivoRepositorio tipoArquivoRepositorio)
            {
            _tipoArquivoRepositorio = tipoArquivoRepositorio;
            }

            [HttpGet]
            public IActionResult Get()
            {
                try
                {
                    return Ok(_tipoArquivoRepositorio.ObterTodos());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }

        }
    }
