using Equals.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equals.Repositorio.Config
{
    public class LogErroConfiguration : IEntityTypeConfiguration<LogErro>
    {
        public void Configure(EntityTypeBuilder<LogErro> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.ArquivoId);

            builder.Property(l => l.Mensagem);

            builder.Property(l => l.DataProcessamento);

        }
    }
}
