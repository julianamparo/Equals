using Equals.Dominio.Contratos;
using Equals.Dominio.Entidades;
using Equals.Repositorio.Contexto;

namespace Equals.Repositorio.Repositorios
{
    public class LogErroRepositorio : BaseRepositorio<LogErro>, ILogErroRepositorio
    {
        public LogErroRepositorio(EqualsContexto equalsContexto) : base(equalsContexto)
        {
        }
    }
}
