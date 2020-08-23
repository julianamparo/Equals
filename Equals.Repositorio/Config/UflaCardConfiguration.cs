using Equals.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equals.Repositorio.Config
{
    public class UflaCardConfiguration : IEntityTypeConfiguration<UflaCard>
    {
        public void Configure(EntityTypeBuilder<UflaCard> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.TipoRegistro)
                   .IsRequired();
            builder.Property(u => u.Estabelecimento)
                   .IsRequired();
            builder.Property(u => u.DataProcessamento)
                   .IsRequired();
            builder.Property(u => u.PeriodoInicial)
                   .IsRequired();
            builder.Property(u => u.PeriodoFinal)
                   .IsRequired();
            builder.Property(u => u.Sequencia)
                   .IsRequired();
            builder.Property(u => u.Adquirente)
                   .IsRequired();
            builder.Property(u => u.ArquivoId)
                   .IsRequired();

        }
    }
}
