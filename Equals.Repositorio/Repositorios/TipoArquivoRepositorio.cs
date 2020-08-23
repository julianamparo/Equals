using Equals.Dominio.Contratos;
using Equals.Dominio.Entidades;
using Equals.Repositorio.Contexto;

namespace Equals.Repositorio.Repositorios
{
    public class TipoArquivoRepositorio : BaseRepositorio<TipoArquivo>, ITipoArquivoRepositorio
    {
        public TipoArquivoRepositorio(EqualsContexto equalsContexto) : base(equalsContexto)
        {
        }
    }
}
