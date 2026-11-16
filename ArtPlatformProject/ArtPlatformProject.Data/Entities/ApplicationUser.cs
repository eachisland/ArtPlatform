using ArtPlatformProject.Data.Entities.ArtPlatformProject.Data.Entities;
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

        public ICollection<Like> Likes { get; set; } = new List<Like>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public ICollection<ArtworkView> ArtworkViews { get; set; } = new List<ArtworkView>();

        public ICollection<Follow> Following { get; set; } = new List<Follow>();

        public ICollection<Follow> Followers { get; set; } = new List<Follow>();

        public UserPreference? UserPreference { get; set; }

    }
}
