using ArtisanHub.Application.Repositories;
using ArtisanHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArtisanHub.Infrastructure.Repositories;

public class UserRepository(ApplicationDbContext context) : IUserRepository
{
    public void CreateUser(User user) =>
        context.Users.Add(user);

    public async Task<bool> IsEmailRegisteredAsync(string email, CancellationToken cancellationToken) =>
        await context.Users
            .AnyAsync(user =>
                user.Email.ToLower().Equals(email.ToLower()), cancellationToken);
}