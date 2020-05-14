using Domain.Produtos;
using Infra.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infra.EntityFramework.Repositories.Produto
{
	public class ProdutoRepository : IProdutoRepository
	{
		private readonly MySqlContext context;

		public ProdutoRepository(MySqlContext context)
		{
			this.context = context;
		}

    public async Task<ProdutoData> Add(ProdutoData entity)
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

    public IQueryable<ProdutoData> Get(Expression<Func<ProdutoData, bool>> expression)
    {
      return context.Produtos.Where(expression);
    }

    public async Task<ProdutoData> Remove(ProdutoData entity)
    {
      context.Remove(entity);
      return await Task.FromResult(entity);
    }

    public async Task<ProdutoData> Update(ProdutoData entity)
    {
      context.Update(entity);
      return await Task.FromResult(entity);
    }
  }
}