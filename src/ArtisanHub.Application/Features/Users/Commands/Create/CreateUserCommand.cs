using ArtisanHub.Domain.Shared;
using MediatR;

namespace ArtisanHub.Application.Features.Users.Commands.Create;

public record CreateUserCommand(
    string Username,
    string Email,
    string Password) :IRequest<Result<Guid>>;