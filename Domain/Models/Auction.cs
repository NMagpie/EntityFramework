using AuctionApp.Domain.Enumerators;

namespace AuctionApp.Domain.Models;
public class Auction
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public DateTimeOffset StartTime { get; set; }

    public DateTimeOffset EndTime { get; set; }

    public AuctionStatus Status { get; set; }

    public ICollection<Lot> Lots { get; set; } = [];

    public ICollection<Bid> Bids { get; set; } = [];
}
