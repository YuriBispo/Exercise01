using Domain.Clientes;
using Infra.EntityFramework.Data;
using Infra.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EntityFramework.Repositories.Cliente
{
  public class PedidoRepository : IPedidoRepository
  {
    private readonly MySqlContext context;

    public PedidoRepository(MySqlContext context)
    {
      this.context = context;
    }

    public async Task<PedidoData> Add(PedidoData entity)
    {
      context.Add(entity);
      return await Task.FromResult(entity);
    }

    public async Task CommitChangesAsync()
    {
      await context.SaveChangesAsync();
    }

    public void CommitChanges()
    {
      context.SaveChanges();
    }

    public IQueryable<PedidoData> Get(Expression<Func<PedidoData, bool>> expression)
    {
      return context.Pedidos.Where(expression);
    }

    public async Task<PedidoData> Remove(PedidoData entity)
    {
      context.Remove(entity);
      return await Task.FromResult(entity);
    }

    public async Task<PedidoData> Update(PedidoData entity)
    {
      context.Update(entity);
      return await Task.FromResult(entity);
    }
  }
}
