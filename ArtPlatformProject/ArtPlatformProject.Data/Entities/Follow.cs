using System;
using System.Collections.Generic;
using System.Text;

namespace ArtPlatformProject.Data.Entities
{
    public class Follow
    {
        public string FollowerId { get; set; } = "";
        public ApplicationUser Follower { get; set; } = null!;

        public string FollowedId { get; set; } = "";
        public ApplicationUser Followed { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
