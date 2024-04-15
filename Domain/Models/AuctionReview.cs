﻿using EntityFramework.Domain.Abstractions;

namespace AuctionApp.Domain.Models
{
    public class AuctionReview : Entity
    {
        public User? User { get; set; }

        public int? UserId { get; set; }

        public required Auction Auction { get; set; }

        public required int AuctionId { get; set; }

        public string? ReviewText { get; set; }

        public required float Rating { get; set; }
    }
}
