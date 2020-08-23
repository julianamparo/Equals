using Equals.Dominio.Entidades;
using Equals.Repositorio.Config;
using Microsoft.EntityFrameworkCore;

namespace Equals.Repositorio.Contexto
{
    public class EqualsContexto : DbContext
    {
        public DbSet<Arquivo> Arquivos { get; set; }

        public DbSet<Adquirente> Adquirentes { get; set; }

        public DbSet<FagammonCard> FagammonCards { get; set; }
        public DbSet<UflaCard> UflaCards { get; set; }

        public DbSet<TipoArquivo> TipoArquivos { get; set; }

        public DbSet<LogErro> LogErros { get; set; }
              
        public EqualsContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArquivoConfiguration());
            modelBuilder.ApplyConfiguration(new AdquirenteConfiguration());
            modelBuilder.ApplyConfiguration(new FagammonCardConfiguration());
            modelBuilder.ApplyConfiguration(new LogErroConfiguration());
            modelBuilder.ApplyConfiguration(new TipoArquivoConfiguration());
            modelBuilder.ApplyConfiguration(new UflaCardConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
