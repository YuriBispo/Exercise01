using Domain.Produtos;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infra.EntityFramework.Repositories
{
  public interface IProdutoRepository : IRepository
  {
    IQueryable<Produto> Get(Expression<Func<Produto, bool>> expression);
    Task<Produto> Add(Produto entity);
    Task<Produto> Update(Produto entity);
    Task<Produto> Remove(Produto id);
  }
}