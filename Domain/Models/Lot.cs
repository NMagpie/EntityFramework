namespace AuctionApp.Domain.Models;
public class Lot
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public string? Description { get; set; }

    public Auction? Auction { get; set; }

    //TODO IGNORE THIS FIELD IN DB, APPLICATION ONLY
    public decimal InitialPrice { get; set; }

    public decimal Price { get; set; }

    public ICollection<Bid> Bids { get; set; } = [];
}
