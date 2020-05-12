using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infra.EntityFramework.Repositories
{
	public interface IRepository<T>
	{
		Task CommitChanges();
	}
}