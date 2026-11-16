using System;
using System.Collections.Generic;
using System.Text;

namespace ArtPlatformProject.Data.Entities
{
    public class ArtworkView
    {
        public int Id { get; set; }

        public int ArtworkId { get; set; }
        public Artwork Artwork { get; set; } = null!;

        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public DateTime ViewedAt { get; set; } = DateTime.UtcNow;
    }
}
