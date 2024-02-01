using ArtisanHub.Domain.Entities.Base;
using ArtisanHub.Domain.Enums;

namespace ArtisanHub.Domain.Entities;

public class Account(Guid id, string username, string email, string passwordHash, Role role) : Entity(id)
{
    private readonly List<Supplier> _suppliers = [];

    public string Username { get; private set; } = username;
    public string Email { get; private set; } = email;
    public string PasswordHash { get; private set; } = passwordHash;
    public Role Role { get; private set; } = role;
    public IReadOnlyCollection<Supplier> Suppliers => _suppliers;
}