using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Application.Services.CompanyServices;
using OnlineMuhasebeServer.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineMuhasebeServer.Domain.UnitOfWorks;
using OnlineMuhasebeServer.Domain;
using OnlineMuhasebeServer.Persistance.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineMuhasebeServer.Persistance.Services.AppServices;
using OnlineMuhasebeServer.Persistance.Services.CompanyServices;
using OnlineMuhasebeServer.Persistance;

namespace OnlineMuhasebeServer.WebApi.Configurations
{
	public class PersistanceDIServiceInstaller : IServiceInstaller
	{
		public void Install(IServiceCollection services, IConfiguration configuration)
		{
			#region Context UnitOfWork
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddScoped<IContextService, ContextService>();
			#endregion


			#region Services
			#region CompanyDbContext
			services.AddScoped<IUCAFService, UCAFService>();
			//CompanyServiceDISpot
			#endregion

			#region AppDbContext
			services.AddScoped<ICompanyService, CompanyService>();
			//AppServiceDISpot
			#endregion

			#endregion


			#region Repositories
			#region CompanyDbContext

			services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
			services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
			//CompanyRepositoryDISpot

			#region AppDbContext
			//AppRepositoryDISpot
			#endregion

			#endregion
			#endregion
		}
	}
}
