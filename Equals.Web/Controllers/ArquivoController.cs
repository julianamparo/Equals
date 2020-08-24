 using Equals.Dominio.Contratos;
using Equals.Dominio.Entidades;
using Equals.Repositorio.Repositorios;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.IO;

namespace Equals.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ArquivoController : Controller
    {
        private readonly IArquivoRepositorio _arquivoRepositorio;
        private readonly IFagammonCardRepositorio _fagammonCardRepositorio;
        private readonly IUflaCardRepositorio _uflaCardRepositorio;
        private IHttpContextAccessor _httpContextAccessor;
        private IHostingEnvironment _hostingEnvironment;
        public ArquivoController(IArquivoRepositorio arquivoRepositorio,
                                      IFagammonCardRepositorio fagammonCardRepositorio,
                                        IUflaCardRepositorio uflaCardRepositorio, 
                                             IHttpContextAccessor httpContextAccessor,
                                                 IHostingEnvironment hostingEnvironment)
        {
            _arquivoRepositorio = arquivoRepositorio;
            _fagammonCardRepositorio = fagammonCardRepositorio;
            _uflaCardRepositorio = uflaCardRepositorio;
            _httpContextAccessor = httpContextAccessor;
            _hostingEnvironment = hostingEnvironment;
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

        [HttpPost("ArquivoUpload")]
        public IActionResult arquivoUpload()
        {
            try
            {
                var formFile = _httpContextAccessor.HttpContext.Request.Form.Files["arquivoCarregado"];
                var filename = formFile.FileName;
                var caminhoCompleto = _hostingEnvironment.WebRootPath + "\\backup\\" + filename;
                Arquivo a = new Arquivo();
                a.NomeArquivo = filename;
                a.Recepcionado = true;
                a.DataRecepcao = DateTime.Now;
                if (filename.Contains("FagammonCard"))
                     a.AdquirenteId = 1;
                if (filename.Contains("UflaCard"))
                    a.AdquirenteId = 2;
                a.TipoArquivoId = 1;

                _arquivoRepositorio.Adicionar(a);

                using (var streamArquivo = new FileStream(caminhoCompleto, FileMode.Create))
                {
                    formFile.CopyTo(streamArquivo);

                    using (var streamReader = new StreamReader(streamArquivo))
                    {
                        string linha = streamReader.ReadLine();
                        if (linha.Contains("FagammonCard")) {
                            FagammonCard fcard = new FagammonCard();
                            fcard.TipoRegistro = "0";
                            fcard.DataProcessamento = DateTime.Parse(linha.Substring(1, 8));
                            fcard.Estabelecimento = linha.Substring(9, 8);
                            fcard.Adquirente = linha.Substring(17, 12);
                            fcard.Sequencia = linha.Substring(29, 7);
                            _fagammonCardRepositorio.Adicionar(fcard);
                        }
                        if (linha.Contains("UflaCard")) {
                            UflaCard uCard = new UflaCard();
                            uCard.TipoRegistro = "0";
                            uCard.Estabelecimento = linha.Substring(1, 10);
                            uCard.DataProcessamento = DateTime.Parse(linha.Substring(11, 8));
                            uCard.PeriodoInicial = DateTime.Parse(linha.Substring(19, 8));
                            uCard.PeriodoFinal = DateTime.Parse(linha.Substring(27, 8));
                            uCard.Sequencia = linha.Substring(35, 7);
                            uCard.Adquirente = linha.Substring(42, 8);
                            _uflaCardRepositorio.Adicionar(uCard);
                        }

                    }
                }
                return Ok("Arquivo Carregado");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }
    }
}
