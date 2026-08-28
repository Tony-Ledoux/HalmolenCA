using HalmolenCA.Domain.Entities.Facilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HalmolenCA.Infrastructure.Persistence.Context.Configurations;

public class FloorConfiguration : IEntityTypeConfiguration<Floor>
{
    public void Configure(EntityTypeBuilder<Floor> builder)
    {
        builder.HasKey(f => f.Id);
        builder.Property(f => f.Id).ValueGeneratedOnAdd();
        builder.Property(f => f.Name).IsRequired().HasMaxLength(50);
        builder.Property(f => f.Level).IsRequired();
        builder.HasIndex(f => f.Name).IsUnique();
    }
}
