using AuctionApp.Domain.Enumerators;

namespace EntityFramework.Domain.Models;

public class AuctionStatus
{
    public required AuctionStatusId AuctionStatusId { get; set; }
    public required string Status { get; set; }
}
