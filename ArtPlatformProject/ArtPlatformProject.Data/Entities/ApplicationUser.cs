using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtPlatformProject.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string DisplayName { get; set; } = "";
        public string? Bio { get; set; }
        public string? ProfileImageUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Artwork> Artworks { get; set; } = new List<Artwork>();
    }
}
