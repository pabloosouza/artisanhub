using ArtisanHub.Domain.Entities.Base;

namespace ArtisanHub.Domain.Entities;

public class Supplier(Guid id, string name, string registryNumber, string contact) : Entity(id)
{
    private readonly List<Product> _products = [];
    
    public string Name { get; private set; } = name;
    public string RegistryNumber { get; private set; } = registryNumber;
    public string Contact { get; private set; } = contact;
    public Guid UserId { get; private set; }
    public User? User { get; private set; }
    public IReadOnlyCollection<Product> Products => _products;
}