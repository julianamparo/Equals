using System;

namespace Equals.Dominio.Entidades
{
    public class FagammonCard : Entidade
    {
        public int Id { get; set; }
        public string TipoRegistro { get; set; }

        public DateTime DataProcessamento { get; set; }

        public string Estabelecimento { get; set; }
        public string Adquirente { get; set; }

        public string Sequencia { get; set; }

        public int ArquivoId { get; set; }

        public virtual Arquivo Arquivo { get; set; }

        public override void Validate()
        {
            LimparMensagens();

            if (TipoRegistro == null)
                AdicionarMensagem("Erro no arquivo - TipoRegistro não pode estar nulo");
            if (DataProcessamento == null)
                AdicionarMensagem("Erro no arquivo - Data de Processamento não pode estar nulo");
            if (Estabelecimento == null)
                AdicionarMensagem("Erro no arquivo - Estabelecimento não pode estar nulo");
            if (Adquirente == null)
                AdicionarMensagem("Erro no arquivo - Adquirente não pode estar nulo");
            if (Sequencia == null)
                AdicionarMensagem("Erro no arquivo - Sequencia não pode estar nulo");
            
        }
    }
}
