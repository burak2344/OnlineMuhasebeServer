using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Application.Services.CompanyServices;
using OnlineMuhasebeServer.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineMuhasebeServer.Domain.UnitOfWorks;
using OnlineMuhasebeServer.Domain;
using OnlineMuhasebeServer.Persistance.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineMuhasebeServer.Persistance.Services.AppServices;
using OnlineMuhasebeServer.Persistance.Services.CompanyServices;
using OnlineMuhasebeServer.Persistance;
using OnlineMuhasebeServer.Persistance.UnitOfWorks;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.CompanyRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.CompanyRepositories;

namespace OnlineMuhasebeServer.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
	{
		public void Install(IServiceCollection services, IConfiguration configuration)
		{
			#region Context UnitOfWork
			services.AddScoped<ICompanyDbUnitOfWork, CompanyDbUnitOfWork>();
			services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
			services.AddScoped<IContextService, ContextService>();
			#endregion


			#region Services
			#region CompanyDbContext
			services.AddScoped<IUCAFService, UCAFService>();
				//CompanyServiceDISpot
				#endregion

				#region AppDbContext
				services.AddScoped<ICompanyService, CompanyService>();
				services.AddScoped<IRoleService, RoleService>();
				//AppServiceDISpot
				#endregion

			#endregion


			#region Repositories

					#region CompanyDbContext
					services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
					services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
				    //CompanyRepositoryDISpot
				    #endregion

				    #region AppDbContext
				    services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
					services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
					//AppRepositoryDISpot
					#endregion

			#endregion
		}
	}
}
