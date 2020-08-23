using Equals.Dominio.Contratos;
using Equals.Dominio.Entidades;
using Equals.Repositorio.Contexto;

namespace Equals.Repositorio.Repositorios
{
    public class AdquirenteRepositorio : BaseRepositorio<Adquirente>, IAdquirenteRepositorio
    {
        public AdquirenteRepositorio(EqualsContexto equalsContexto) : base(equalsContexto)
        {
        }
    }
}
