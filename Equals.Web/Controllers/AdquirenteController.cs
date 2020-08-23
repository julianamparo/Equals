using Equals.Dominio.Contratos;
using Equals.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Equals.Web.Controllers
{
    [Route("api/[Controller]")]
    public class AdquirenteController : Controller
    {
        private readonly IAdquirenteRepositorio _adquirenteRepositorio;
        public AdquirenteController(IAdquirenteRepositorio adquirenteRepositorio)
        {
            _adquirenteRepositorio = adquirenteRepositorio;
        }

 
        public IEnumerable<Adquirente> Get()
        {
            return _adquirenteRepositorio.ObterTodos();
        }

    }

}