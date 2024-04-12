namespace AuctionApp.Domain.Models
{
    public class UserWatchlist
    {
        public int Id { get; set; }
        
        public required User User { get; set; }

        public required Auction Auction { get; set; }
    }
}
