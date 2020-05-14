using Domain.Clientes;
using Infra.EntityFramework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EntityFramework.Repositories.Cliente
{
  public class ClienteRepository : IClienteRepository
  {
    private readonly MySqlContext context;

    public ClienteRepository(MySqlContext context)
    {
      this.context = context;
    }

    public async Task<ClienteData> Add(ClienteData entity)
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

    public IQueryable<ClienteData> Get(Expression<Func<ClienteData, bool>> expression)
    {
      return context.Clientes.Where(expression);
    }

    public async Task<ClienteData> Remove(ClienteData entity)
    {
      context.Remove(entity);
      return await Task.FromResult(entity);
    }

    public async Task<ClienteData> Update(ClienteData entity)
    {
      context.Update(entity);
      return await Task.FromResult(entity);
    }
  }
}
