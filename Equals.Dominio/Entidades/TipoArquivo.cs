using System.Collections.Generic;

namespace Equals.Dominio.Entidades
{
    public class TipoArquivo : Entidade
    {
        public int Id { get; set; }
        public string NomeTipoArquivo { get; set; }

        //public virtual ICollection<Arquivo> Arquivos { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
