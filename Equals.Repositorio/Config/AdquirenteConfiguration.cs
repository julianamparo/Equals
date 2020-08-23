using Equals.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Equals.Repositorio.Config
{
    public class AdquirenteConfiguration : IEntityTypeConfiguration<Adquirente>
    {
        public void Configure(EntityTypeBuilder<Adquirente> builder)
        {
            builder.HasKey(ad => ad.Id);

            builder.Property(ad => ad.NomeAdquirente)
                   .IsRequired();
            //builder
            //      .HasMany(ad => ad.Arquivos)
            //      .WithOne(a => a.Adquirente);                 

        }
    }
}
