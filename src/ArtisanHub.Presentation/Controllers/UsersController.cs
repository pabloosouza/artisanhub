using ArtisanHub.Application.Features.Users.Commands.Create;
using ArtisanHub.Application.InputModels.Users;
using ArtisanHub.Presentation.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ArtisanHub.Presentation.Controllers;

[Route("api/v1/users")]
public class UsersController(ISender sender) : ApiController(sender)
{
    private readonly ISender _sender = sender;

    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUserInputModel input)
    {
        var command = new CreateUserCommand(input.Username, input.Email, input.Password);

        var result = await _sender.Send(command);

        return Test(result);
    }
}