using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.GenericRepositories.AppDbContext;

namespace OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleAndRoleRelationshipRepositories
{
	public class MainRoleAndRoleRelationshipQueryRepository : AppQueryRepository<MainRoleAndRoleRelationship>, IMainRoleAndRoleRelationshipQueryRepository
	{
		public MainRoleAndRoleRelationshipQueryRepository(Persistance.Context.AppDbContext context) : base(context) { }
	}
}
