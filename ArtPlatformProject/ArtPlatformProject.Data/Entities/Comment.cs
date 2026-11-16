using System;
using System.Collections.Generic;
using System.Text;

namespace ArtPlatformProject.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; } = "";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public string UserId { get; set; } = "";
        public ApplicationUser User { get; set; } = null!;

        public int ArtworkId { get; set; }
        public Artwork Artwork { get; set; } = null!;
    }
}
