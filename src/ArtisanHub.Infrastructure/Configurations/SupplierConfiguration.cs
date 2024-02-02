using ArtisanHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtisanHub.Infrastructure.Configurations;

public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder.HasIndex(supplier => supplier.RegistryNumber)
            .IsUnique();
        builder.HasQueryFilter(supplier => !supplier.IsDeleted);
    }
}