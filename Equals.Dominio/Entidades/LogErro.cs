using System;

namespace Equals.Dominio.Entidades
{
    public class LogErro
    {
        public int Id { get; set; }
        public int ArquivoId { get; set; }
        public virtual Arquivo Arquivo { get; set; }

        public string Mensagem { get; set; }
        public DateTime DataProcessamento { get; set; }

    }
}
