using ArtPlatformProject.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArtPlatformProject.Data.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Mood> Moods { get; set; }
    }
}