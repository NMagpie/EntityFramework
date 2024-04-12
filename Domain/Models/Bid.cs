namespace AuctionApp.Domain.Models;
public class Bid
{
    public int Id { get; set; }

    public Lot Lot { get; set; }

    public decimal Amount { get; set; }

    public DateTimeOffset CreateTime { get; set; }

    public bool IsWon { get; set; }
}