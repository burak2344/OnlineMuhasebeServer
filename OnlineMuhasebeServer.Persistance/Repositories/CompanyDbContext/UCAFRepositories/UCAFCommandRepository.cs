using OnlineMuhasebeServer.Domain.CompanyEntities;
using OnlineMuhasebeServer.Domain.Repositories.CompanyDbContext.UCAFRepositories;

namespace OnlineMuhasebeServer.Persistance.Repositories.CompanyDbContext.UCAFRepositories
{
	public sealed class UCAFCommandRepository : CommandRepository<UniformChartOfAccount>,IUCAFCommandRepository
	{
	}
}
