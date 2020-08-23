using Equals.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equals.Repositorio.Config
{
    public class TipoArquivoConfiguration : IEntityTypeConfiguration<TipoArquivo>
    {
        public void Configure(EntityTypeBuilder<TipoArquivo> builder)
        {
            builder.HasKey(ta => ta.Id);

            builder.Property(ta => ta.NomeTipoArquivo)
                   .IsRequired();
            //builder
            //      .HasMany(ta => ta.Arquivos)
            //      .WithOne(a => a.TipoArquivo);
        }
    }
}
