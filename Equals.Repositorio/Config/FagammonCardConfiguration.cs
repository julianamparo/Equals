using Equals.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equals.Repositorio.Config
{
    public class FagammonCardConfiguration : IEntityTypeConfiguration<FagammonCard>
    {
        public void Configure(EntityTypeBuilder<FagammonCard> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.TipoRegistro)
                   .IsRequired();
            builder.Property(f => f.DataProcessamento)
                   .IsRequired();
            builder.Property(f => f.Estabelecimento)
                   .IsRequired();
            builder.Property(f => f.Adquirente)
                   .IsRequired();
            builder.Property(f => f.Sequencia)
                   .IsRequired();
            builder.Property(f => f.ArquivoId)
                   .IsRequired();
        }
    }
}
