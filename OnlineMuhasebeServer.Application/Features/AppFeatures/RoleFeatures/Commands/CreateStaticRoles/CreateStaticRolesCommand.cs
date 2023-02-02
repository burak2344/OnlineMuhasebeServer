using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateStaticRoles
{
	public sealed record CreateStaticRolesCommand() : ICommand<CreateStaticRolesCommandResponse>;

}
