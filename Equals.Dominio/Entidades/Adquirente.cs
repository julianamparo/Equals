using System.Collections;
using System.Collections.Generic;

namespace Equals.Dominio.Entidades
{
    public class Adquirente : Entidade
    {
        public int Id { get; set; }
        public string NomeAdquirente { get; set; }

        //public virtual ICollection<Arquivo> Arquivos { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
