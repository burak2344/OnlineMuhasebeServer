using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Abstractions;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.AuthFeatures.Commands.Login
{
	public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
	{
		private readonly IJwtProvider _jwtProvider;
		private readonly UserManager<AppUser> _userManager;

		public LoginCommandHandler(UserManager<AppUser> userManager, IJwtProvider jwtProvider)
		{
			_userManager = userManager;
			_jwtProvider = jwtProvider;
		}

		public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
		{
			AppUser user = await _userManager.Users.Where(p=>p.Email == 
			request.EmailOrUserName || p.UserName == 
			request.EmailOrUserName).FirstOrDefaultAsync();
			if (user == null)throw new Exception("Kullanıcı Bulunamadı!");
			
			var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);
			if (!checkUser) throw new Exception("Şifre Yanlış!");
			

			LoginCommandResponse response = new(
			   Token: await _jwtProvider.CreateTokenAsycn(user),
			   Email: user.Email,
			   UserId: user.Id,
			   NameLastName: user.NameLastName
			   
			   );

			return response;

		}
	}
}
