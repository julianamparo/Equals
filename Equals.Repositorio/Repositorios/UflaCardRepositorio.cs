using Equals.Dominio.Contratos;
using Equals.Dominio;
using Equals.Dominio.Entidades;
using Equals.Repositorio.Contexto;

namespace Equals.Repositorio.Repositorios
{
    public class UflaCardRepositorio : BaseRepositorio<UflaCard>, IUflaCardRepositorio
    {
        public UflaCardRepositorio(EqualsContexto equalsContexto) : base(equalsContexto)
        {
        }
    }
}
