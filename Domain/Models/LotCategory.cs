using AuctionApp.Domain.Models;

namespace EntityFramework.Domain.Models;
public class LotCategory
{
    public required int LotId { get; set; }

    public required Lot Lot { get; set; }

    public required int CategoryId { get; set; }

    public required Category Category { get; set; }
}
