using Equals.Dominio.Contratos;
using Equals.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace Equals.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly EqualsContexto EqualsContexto;
        public BaseRepositorio(EqualsContexto equalsContexto)
        {
            EqualsContexto = equalsContexto;

        }
        public void Adicionar(TEntity entity)
        {
            EqualsContexto.Set<TEntity>().Add(entity);
        }

        public void Atualizar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
      
        public TEntity ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return EqualsContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            EqualsContexto.Dispose();
        }
    }
}
