using System;
using System.Collections.Generic;
using System.Text;

namespace ArtPlatformProject.Data.Entities
{
    public class Artwork
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string? Description { get; set; }
        public string ImageUrl { get; set; } = "";
        public string? CloudinaryPublicId { get; set; }
        public string DominantColor { get; set; } = "";
        public string Visibility { get; set; } = "Public";
        public int ViewCount { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string AuthorId { get; set; } = "";
        public ApplicationUser Author { get; set; } = null!;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public int MoodId { get; set; }
        public Mood Mood { get; set; } = null!;
        public ICollection<Like> Likes { get; set; } = new List<Like>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public ICollection<ArtworkView> Views { get; set; } = new List<ArtworkView>();

        public ICollection<ArtworkTag> ArtworkTags { get; set; } = new List<ArtworkTag>();
    }
}
