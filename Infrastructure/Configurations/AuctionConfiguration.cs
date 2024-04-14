using AuctionApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Infrastructure.Configurations
{
    public class AuctionConfiguration : IEntityTypeConfiguration<Auction>
    {
        public void Configure(EntityTypeBuilder<Auction> builder)
        {

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.Title)
                .HasMaxLength(256);

            builder
                .Property(x => x.StatusId)
                .HasConversion<int>();

            builder
                .HasMany(x => x.Lots)
                .WithOne(x => x.Auction)
                .HasForeignKey(x => x.AuctionId)
                .IsRequired(false);

            builder
                .HasOne(x => x.Creator)
                .WithOne()
                .HasForeignKey<Auction>(x => x.CreatorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(x => x.Status)
                .WithOne()
                .HasForeignKey<Auction>(x => x.StatusId);
        }
    }
}
