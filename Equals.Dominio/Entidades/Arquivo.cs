using System;
using System.Collections;
using System.Collections.Generic;

namespace Equals.Dominio.Entidades
{
    public class Arquivo : Entidade
    {
        public int Id { get; set; }
        public string NomeArquivo { get; set; }

        public bool Recepcionado { get; set; }

        public DateTime DataRecepcao { get; set; }

        public int TipoArquivoId { get; set; }

        public virtual TipoArquivo TipoArquivo { get; set; }

        public int AdquirenteId { get; set; }

        public virtual Adquirente Adquirente { get; set; }

       // public virtual ICollection<LogErro> LogErros { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
