using Equals.Dominio.Contratos;
using Equals.Dominio.Entidades;
using Equals.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace Equals.Repositorio.Repositorios
{
    public class ArquivoRepositorio : BaseRepositorio<Arquivo>, IArquivoRepositorio
    {
        public ArquivoRepositorio(EqualsContexto equalsContexto) : base(equalsContexto)
        {
        }
    }
}
