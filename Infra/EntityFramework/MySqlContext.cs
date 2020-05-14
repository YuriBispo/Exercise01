using Domain.Produtos;
using Domain.Produtos.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infra.EntityFramework
{
  public class MySqlContext : DbContext
  {
    public DbSet<Produto> Produtos { get; set; }

    public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Produto>()
        .ToTable("produtos");

      builder.Entity<Produto>()
        .HasKey(x => x.Id);

      builder.Entity<Produto>()
        .HasDiscriminator(x => x.Fabricacao)
        .HasValue<ProdutoNacional>(Fabricacao.Nacional)
        .HasValue<ProdutoInternacional>(Fabricacao.Importado);

      builder.Entity<Produto>()
        .OwnsOne(x => x.Tamanho)
        .Property<string>("Tamanho")
        .HasColumnName("Tamanho");

      builder.Entity<Produto>()
        .OwnsOne(x => x.Valor)
        .Property<decimal>("Valor")
        .HasColumnName("Valor");

      base.OnModelCreating(builder);
    }
  }
}