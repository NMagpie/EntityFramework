using EntityFramework.Domain.Abstractions;

namespace AuctionApp.Domain.Models;
public class Lot : Entity
{
    public required string Title { get; set; }

    public string? Description { get; set; }

    public Auction? Auction { get; set; }

    public int? AuctionId { get; set; }

    public decimal? InitialPrice { get; set; }

    public decimal Price { get; set; }

    public ICollection<Bid> Bids { get; set; } = [];
}
