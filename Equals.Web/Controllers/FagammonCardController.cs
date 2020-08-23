using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Equals.Dominio.Contratos;
using Equals.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Equals.Web.Controllers
{
    public class FagammonCardController : Controller
    {
        private readonly IFagammonCardRepositorio _fagammonCardRepositorio;
        public FagammonCardController(IFagammonCardRepositorio fagammonCardRepositorio)
        {
            _fagammonCardRepositorio = fagammonCardRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<FagammonCard> fagammonCards = (List<FagammonCard>)_fagammonCardRepositorio.ObterTodos();   
                return Ok(fagammonCards);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody] FagammonCard fagammoncards)
        {
            try
            {
                _fagammonCardRepositorio.Adicionar(fagammoncards);
                return Created("api/fagammoncard", fagammoncards);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
