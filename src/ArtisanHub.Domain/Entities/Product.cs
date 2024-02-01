using ArtisanHub.Domain.Entities.Base;

namespace ArtisanHub.Domain.Entities;

public class Product(Guid id, string description, decimal price) : Entity(id)
{
    public string Description { get; private set; } = description;
    public decimal Price { get; private set; } = price;
    public Guid SupplierId { get; private set; }
    public Supplier? Supplier { get; private set; }
}