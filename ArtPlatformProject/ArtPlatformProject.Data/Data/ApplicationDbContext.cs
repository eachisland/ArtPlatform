using ArtPlatformProject.Data.Entities;
using ArtPlatformProject.Data.Entities.ArtPlatformProject.Data.Entities;
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

        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<ArtworkTag> ArtworkTags { get; set; }

        public DbSet<UserPreference> UserPreferences { get; set; }
        public DbSet<Follow> Follows { get; set; }

        public DbSet<ArtworkView> ArtworkViews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Like>()
                .HasKey(l => new { l.UserId, l.ArtworkId });

            builder.Entity<ArtworkTag>()
                .HasKey(at => new { at.ArtworkId, at.TagId });

            builder.Entity<Follow>()
                .HasKey(f => new { f.FollowerId, f.FollowedId });

            builder.Entity<UserPreference>()
                .HasKey(up => up.UserId);

            builder.Entity<UserPreference>()
                .HasOne(up => up.User)
                .WithOne(u => u.UserPreference)
                .HasForeignKey<UserPreference>(up => up.UserId);

            builder.Entity<Follow>()
                .HasOne(f => f.Follower)
                .WithMany(u => u.Following)
                .HasForeignKey(f => f.FollowerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Follow>()
                .HasOne(f => f.Followed)
                .WithMany(u => u.Followers)
                .HasForeignKey(f => f.FollowedId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Like>()
                .HasOne(l => l.User)
                .WithMany(u => u.Likes)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Like>()
                .HasOne(l => l.Artwork)
                .WithMany(a => a.Likes)
                .HasForeignKey(l => l.ArtworkId);

            builder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<ArtworkTag>()
                .HasOne(at => at.Artwork)
                .WithMany(a => a.ArtworkTags)
                .HasForeignKey(at => at.ArtworkId);

            builder.Entity<ArtworkTag>()
                .HasOne(at => at.Tag)
                .WithMany(t => t.ArtworkTags)
                .HasForeignKey(at => at.TagId);

            builder.Entity<ArtworkView>()
                .HasOne(v => v.User)
                .WithMany(u => u.ArtworkViews)
                .HasForeignKey(v => v.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<ArtworkView>()
                .HasOne(v => v.Artwork)
                .WithMany(a => a.Views)
                .HasForeignKey(v => v.ArtworkId);
        }
    }
}