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
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleReporistories;
using OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleRepositories;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;

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
				services.AddScoped<IMainRoleService, MainRoleService>();
				services.AddScoped<IMainRoleAndRoleRelationshipService, MainRoleAndRoleRelationshipService>();
				services.AddScoped<IMainRoleAndUserRelationshipService, MainRoleAndUserRelationshipService>();
				services.AddScoped<IUserAndCompanyRelationshipService, UserAndCompanyRelationshipService>();
				services.AddScoped<IAuthService, AuthService>();
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
					services.AddScoped<IMainRoleCommandRepository, MainRoleCommandRepository>();
					services.AddScoped<IMainRoleQueryRepository, MainRoleQueryRepository>();
			services.AddScoped<IMainRoleAndRoleRelationshipCommandRepository, MainRoleAndRoleRelationshipCommandRepository>();
			services.AddScoped<IMainRoleAndRoleRelationshipQueryRepository, MainRoleAndRoleRelationshipQueryRepository>();
			services.AddScoped<IMainRoleAndUserRelationshipCommandRepository, MainRoleAndUserRelationshipCommandRepository>();
			services.AddScoped<IMainRoleAndUserRelationshipQueryRepository, MainRoleAndUserRelationshipQueryRepository>();
			services.AddScoped<IUserAndCompanyRelationshipCommandRepository, UserAndCompanyRelationshipCommandRepository>();
			services.AddScoped<IUserAndCompanyRelationshipQueryRepository, UserAndCompanyRelationshipQueryRepository>();

			//AppRepositoryDISpot
			#endregion

			#endregion
		}
	}
}
