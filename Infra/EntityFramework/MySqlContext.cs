using Domain.Clientes;
using Domain.Produtos;
using Domain.Produtos.Enums;
using Infra.EntityFramework.Data;
using Infra.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.EntityFramework
{
  public class MySqlContext : DbContext
  {
    public DbSet<ProdutoData> Produtos { get; set; }
    public DbSet<ClienteData> Clientes { get; set; }
    public DbSet<PedidoData> Pedidos { get; set; }

    public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      
    }
  }
}