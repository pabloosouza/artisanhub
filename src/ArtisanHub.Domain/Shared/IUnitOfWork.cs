namespace ArtisanHub.Domain.Shared;

public interface IUnitOfWork
{
    Task CommitAsync(CancellationToken cancellationToken);
}