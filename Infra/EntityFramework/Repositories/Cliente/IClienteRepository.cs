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
  public interface IClienteRepository : IRepository
  {
    IQueryable<ClienteData> Get(Expression<Func<ClienteData, bool>> expression);
    Task<ClienteData> Add(ClienteData entity);
    Task<ClienteData> Update(ClienteData entity);
    Task<ClienteData> Remove(ClienteData id);
  }
}
