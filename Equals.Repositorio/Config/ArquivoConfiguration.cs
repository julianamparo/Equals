using Equals.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equals.Repositorio.Config
{
    public class ArquivoConfiguration : IEntityTypeConfiguration<Arquivo>
    {
        public void Configure(EntityTypeBuilder<Arquivo> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.NomeArquivo)
                   .HasMaxLength(100)
                   .IsRequired();                   

            builder.Property(a => a.Recepcionado)
                   .IsRequired();
            
            builder.Property(a => a.DataRecepcao);

            builder.Property(a => a.AdquirenteId)
                   .IsRequired();

            builder.Property(a => a.TipoArquivoId)
                   .IsRequired();

            //builder
            //     .HasMany(a => a.LogErros)
            //     .WithOne(l => l.Arquivo);

        }
    }
}
