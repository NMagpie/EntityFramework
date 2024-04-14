using AuctionApp.Domain.Enumerators;
using EntityFramework.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Infrastructure.Configurations;
public class AuctionStatusConfiguration : IEntityTypeConfiguration<AuctionStatus>
{
    public void Configure(EntityTypeBuilder<AuctionStatus> builder)
    {
        builder
            .Property(x => x.AuctionStatusId)
            .HasConversion<int>();

        builder
            .HasData(
                Enum.GetValues(typeof(AuctionStatusId))
                    .Cast<AuctionStatusId>()
                    .Select(e => new AuctionStatus()
                    {
                        AuctionStatusId = e,
                        Status = e.ToString()
                    })
            );
    }
}
