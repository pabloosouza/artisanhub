using ArtisanHub.Domain.Shared;

namespace ArtisanHub.Infrastructure.Shared;

public class UnitOfWork(ApplicationDbContext context) : IUnitOfWork
{
    public async Task CommitAsync(CancellationToken cancellationToken) =>
        await context.SaveChangesAsync(cancellationToken);
}