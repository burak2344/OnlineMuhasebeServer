using Microsoft.EntityFrameworkCore;

namespace OnlineMuhasebeServer.Domain.UnitOfWorks
{
	public interface IUnitOfWork
	{
		void SetDbContextInstance(DbContext context);
		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
	}
}
