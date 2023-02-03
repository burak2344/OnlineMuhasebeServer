using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories
{
	public class MainRoleAndUserRelationshipQueryRepository : AppQueryRepository<MainRoleAndUserRelationship>, IMainRoleAndUserRelationshipQueryRepository
	{
		public MainRoleAndUserRelationshipQueryRepository(Persistance.Context.AppDbContext context) : base(context) { }
	}
}
