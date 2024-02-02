using ArtisanHub.Application.Repositories;
using ArtisanHub.Domain.Entities;
using ArtisanHub.Domain.Enums;
using ArtisanHub.Domain.Shared;
using MediatR;

namespace ArtisanHub.Application.Features.Users.Commands.Create;

public class CreateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateUserCommand, Result<Guid>>
{
    public async Task<Result<Guid>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User(Guid.NewGuid(), request.Username, request.Email, request.Password, Role.Artisan);
        
        userRepository.CreateUser(user);
        await unitOfWork.CommitAsync(cancellationToken);

        return Result<Guid>.Ok(user.Id);
    }
}