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
  public interface IPedidoRepository : IRepository
  {
    IQueryable<PedidoData> Get(Expression<Func<PedidoData, bool>> expression);
    Task<PedidoData> Add(PedidoData entity);
    Task<PedidoData> Update(PedidoData entity);
    Task<PedidoData> Remove(PedidoData id);
  }
}
