using System;
using System.Collections.Generic;
using System.Text;

namespace ArtPlatformProject.Data.Entities
{
    public class Like
    {
        public string UserId { get; set; } = "";
        public ApplicationUser User { get; set; } = null!;

        public int ArtworkId { get; set; }
        public Artwork Artwork { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
