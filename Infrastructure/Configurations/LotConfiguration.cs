using AuctionApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Infrastructure.Configurations;
public class LotConfiguration : IEntityTypeConfiguration<Lot>
{
    public void Configure(EntityTypeBuilder<Lot> builder)
    {

        builder
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder
            .Property(x => x.Title)
            .HasMaxLength(256);

        builder
            .Property(x => x.Description)
            .HasMaxLength(2048);

        builder
            .Property(x => x.InitialPrice)
            .HasColumnType("money");

        builder
            .Ignore(x => x.Price);

        builder
            .HasMany(x => x.Bids)
            .WithOne(x => x.Lot)
            .HasForeignKey(x => x.LotId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
