using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Equals.Dominio.Contratos;
using Equals.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Equals.Web.Controllers
{
    public class UflaCardController : Controller
    {
        private readonly IUflaCardRepositorio _uflaCardRepositorio;
        public UflaCardController(IUflaCardRepositorio uflaCardRepositorio)
        {
            _uflaCardRepositorio = uflaCardRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<UflaCard> erros = (List<UflaCard>)_uflaCardRepositorio.ObterTodos();
                return Ok(erros);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost]
        public IActionResult Post([FromBody] UflaCard uflaCard)
        {
            try
            {
                _uflaCardRepositorio.Adicionar(uflaCard);
                return Created("api/uflaCard", uflaCard);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
