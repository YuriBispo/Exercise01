using Domain.Produtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infra.EntityFramework.Repositories
{
	public class ProdutoRepository : IProdutoRepository
	{
		private readonly MySqlContext context;

		public ProdutoRepository(MySqlContext context)
		{
			this.context = context;
		}

    public async Task<Produto> Add(Produto entity)
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

    public IQueryable<Produto> Get(Expression<Func<Produto, bool>> expression)
    {
      return context.Produtos.Where(expression);
    }

    public async Task<Produto> Remove(Produto entity)
    {
      context.Remove(entity);
      return await Task.FromResult(entity);
    }

    public async Task<Produto> Update(Produto entity)
    {
      context.Update(entity);
      return await Task.FromResult(entity);
    }
  }
}