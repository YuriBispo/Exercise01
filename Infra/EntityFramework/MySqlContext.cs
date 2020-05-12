using Domain.Produtos;
using Microsoft.EntityFrameworkCore;

namespace Infra.EntityFramework
{
  public class MySqlContext : DbContext
  {
    DbSet<Produto> Produtos { get; set; }

    public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Produto>()
        .HasKey(x => x.Id);

      builder.Entity<Produto>()
        .OwnsOne(x => x.Tamanho)
        .Property<string>("Tamanho")
        .HasColumnName("Tamanho");

      builder.Entity<Produto>()
        .OwnsOne(x => x.Valor)
        .Property<decimal>("Valor")
        .HasColumnName("Valor");

      ////check if DB exists
      //Database.EnsureCreated();
    }
  }
}