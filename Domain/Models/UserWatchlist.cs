using EntityFramework.Domain.Abstractions;

namespace AuctionApp.Domain.Models
{
    public class UserWatchlist : Entity
    {
        public required User User { get; set; }

        public required int UserId { get; set; }

        public Auction? Auction { get; set; }

        public int? AuctionId { get; set; }
    }
}
