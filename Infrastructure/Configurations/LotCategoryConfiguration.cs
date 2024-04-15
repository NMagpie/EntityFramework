using EntityFramework.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Infrastructure.Configurations;
public class LotCategoryConfiguration : IEntityTypeConfiguration<LotCategory>
{
    public void Configure(EntityTypeBuilder<LotCategory> builder)
    {
        builder
            .HasKey(x => new { x.CategoryId, x.LotId });

        builder
            .HasOne(x => x.Lot)
            .WithMany(x => x.Categories)
            .HasForeignKey(x => x.LotId);

        builder
            .HasOne(x => x.Category)
            .WithMany(x => x.Lots)
            .HasForeignKey(x => x.CategoryId);
    }
}
