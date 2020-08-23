using Equals.Dominio.Contratos;
using Equals.Dominio.Entidades;
using Equals.Repositorio.Contexto;

namespace Equals.Repositorio.Repositorios
{
    public class FagammonCardRepositorio : BaseRepositorio<FagammonCard>, IFagammonCardRepositorio
    {
        public FagammonCardRepositorio(EqualsContexto equalsContexto) : base(equalsContexto)
        {
        }
    }
}
