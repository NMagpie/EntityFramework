namespace AuctionApp.Domain.Models
{
    public class AuctionReview
    {
        public int Id { get; set; }

        public required User User { get; set; }

        public required Auction Auction { get; set; }

        public string? ReviewText { get; set; }

        public float Rating { get; set; }
    }
}
