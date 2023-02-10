using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using OnlineMuhasebeServer.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Abstractions
{
	public interface IJwtProvider
	{
		Task<TokenRefreshTokenDto> CreateTokenAsync(AppUser user);
	}
}
