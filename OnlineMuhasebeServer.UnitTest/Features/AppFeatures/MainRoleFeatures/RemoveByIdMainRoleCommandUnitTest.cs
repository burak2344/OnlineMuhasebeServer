﻿using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveByIdMainRole;
using OnlineMuhasebeServer.Application.Services.AppServices;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.MainRoleFeatures
{
	public sealed class RemoveByIdMainRoleCommandUnitTest
	{
		private readonly Mock<IMainRoleService> _mainRoleService;

		public RemoveByIdMainRoleCommandUnitTest()
		{
			_mainRoleService = new();
		}

		[Fact]
		public async Task RemoveByIdMainRoleCommandResponseShouldNotBeNull()
		{
			var command = new RemoveByIdMainRoleCommand(
				Id: "585985c0-4576-4d62-ae67-59a6f72ae906");

			var handler = new RemoveByIdMainRoleCommandHandler(_mainRoleService.Object);

			RemoveByIdMainRoleCommandResponse response = await handler.Handle(command, default);
			response.ShouldNotBeNull();
			response.Message.ShouldNotBeEmpty();
		}
	}
}
