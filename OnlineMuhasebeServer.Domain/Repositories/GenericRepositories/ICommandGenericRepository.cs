using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Abstractions;

namespace OnlineMuhasebeServer.Domain.Repositories.GenericRepositories
{
	public interface ICommandGenericRepository<T> : IRepository<T>
	where T : Entity
	{
		
		Task AddAsync(T entity);
		Task AddRangeAsync(IEnumerable<T> entities);
		void Update(T entity);
		void UpdateRange(IEnumerable<T> entities);
		Task RemoveById(string id);
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entities);
	}
}
