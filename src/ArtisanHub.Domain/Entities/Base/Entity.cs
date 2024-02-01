namespace ArtisanHub.Domain.Entities.Base;

public abstract class Entity(Guid id)
{
    public Guid Id { get; private set; } = id;
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public bool IsDeleted { get; private set; }

    public void Delete() =>
        IsDeleted = true;
}