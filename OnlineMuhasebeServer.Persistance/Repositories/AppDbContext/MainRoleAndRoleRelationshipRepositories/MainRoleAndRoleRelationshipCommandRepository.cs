using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories
{
	public class MainRoleAndRoleRelationshipCommandRepository : AppCommandRepository<MainRoleAndRoleRelationship>, IMainRoleAndRoleRelationshipCommandRepository
	{
		public MainRoleAndRoleRelationshipCommandRepository(Persistance.Context.AppDbContext context) : base(context) { }
	}
}
