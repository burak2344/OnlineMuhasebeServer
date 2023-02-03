using OnlineMuhasebeServer.Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Queries
{
	public sealed record GetAllMainRoleQueryResponse(
	IList<MainRole> MainRoles);
}
