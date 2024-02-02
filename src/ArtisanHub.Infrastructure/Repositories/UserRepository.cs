using ArtisanHub.Application.Repositories;
using ArtisanHub.Domain.Entities;

namespace ArtisanHub.Infrastructure.Repositories;

public class UserRepository(ApplicationDbContext context) : IUserRepository
{
    public void CreateUser(User user) =>
        context.Users.Add(user);
}