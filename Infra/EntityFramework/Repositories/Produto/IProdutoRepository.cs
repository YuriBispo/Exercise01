using Domain.Produtos;
using Infra.EntityFramework.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infra.EntityFramework.Repositories.Produto
{
  public interface IProdutoRepository : IRepository
  {
    IQueryable<ProdutoData> Get(Expression<Func<ProdutoData, bool>> expression);
    Task<ProdutoData> Add(ProdutoData entity);
    Task<ProdutoData> Update(ProdutoData entity);
    Task<ProdutoData> Remove(ProdutoData id);
  }
}