using ArtisanHub.Domain.Shared;
using Microsoft.EntityFrameworkCore;

namespace ArtisanHub.Infrastructure.Shared;

public class UnitOfWork(DbContext context) : IUnitOfWork
{
    public async Task CommitAsync(CancellationToken cancellationToken) =>
        await context.SaveChangesAsync(cancellationToken);
}