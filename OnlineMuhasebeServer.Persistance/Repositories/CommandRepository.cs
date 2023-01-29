using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.Abstractions;
using OnlineMuhasebeServer.Domain.Repositories.GenericRepositories;
using OnlineMuhasebeServer.Persistance.Context;

namespace OnlineMuhasebeServer.Persistance.Repositories
{
	public class CommandRepository<T> : ICommandGenericRepository<T> 
		where T : Entity
	{
		private static readonly Func<Context.CompanyDbContext, string, Task<T>>
			GetByIdCompiled =
			EF.CompileAsyncQuery((Context.CompanyDbContext context, string id) =>
			context.Set<T>().FirstOrDefault(p=> p.Id == id));
			
		private Context.CompanyDbContext _context;

		public DbSet<T> Entity { get; set; }

		public void SetDbContextInstance(DbContext context)
		{
			_context = (Context.CompanyDbContext)context;
			Entity = _context.Set<T>();
		}
		public async Task AddAsync(T entity)
		{
			await Entity.AddAsync(entity);
		}

		public async Task AddRangeAsync(IEnumerable<T> entities)
		{
			await Entity.AddRangeAsync(entities);
		}

		public void Remove(T entity)
		{
			Entity.Remove(entity);
		}

		public async Task RemoveById(string id)
		{
			T entity = await GetByIdCompiled(_context, id);
			Remove(entity);
		}

		public void RemoveRange(IEnumerable<T> entities)
		{
			Entity.RemoveRange(entities);
		}

		public void Update(T entity)
		{
			Entity.Update(entity);
		}

		public void UpdateRange(IEnumerable<T> entities)
		{
			Entity.UpdateRange(entities);
		}
	}
}
