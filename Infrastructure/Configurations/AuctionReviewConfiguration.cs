using AuctionApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Infrastructure.Configurations;
public class AuctionReviewConfiguration : IEntityTypeConfiguration<AuctionReview>
{
    public void Configure(EntityTypeBuilder<AuctionReview> builder)
    {
        builder
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder
            .Property(x => x.ReviewText)
            .HasMaxLength(2048);

        builder
            .HasOne(x => x.User)
            .WithOne()
            .HasForeignKey<AuctionReview>(x => x.UserId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.SetNull);

        builder
            .HasOne(x => x.Auction)
            .WithOne()
            .HasForeignKey<AuctionReview>(x => x.AuctionId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}