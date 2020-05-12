using Domain.Produtos;
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

    public Task<Produto> Add(Produto entity)
    {
      throw new NotImplementedException();
    }

    public IQueryable<Produto> Get(Expression<Func<object, bool>> expression)
    {
      throw new NotImplementedException();
    }

    public Task<Produto> Remove(Guid id)
    {
      throw new NotImplementedException();
    }

    public Task<Produto> Update(Produto entity)
    {
      throw new NotImplementedException();
    }
  }
}