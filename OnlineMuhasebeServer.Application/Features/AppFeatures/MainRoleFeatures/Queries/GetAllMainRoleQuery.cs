using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Queries
{
	public sealed record GetAllMainRoleQuery() : IQuery<GetAllMainRoleQueryResponse>;
}
