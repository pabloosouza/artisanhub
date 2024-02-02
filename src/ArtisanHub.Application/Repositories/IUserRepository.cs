using ArtisanHub.Domain.Entities;

namespace ArtisanHub.Application.Repositories;

public interface IUserRepository
{
    void CreateUser(User user);
    Task<bool> IsEmailRegisteredAsync(string email, CancellationToken cancellationToken);
}