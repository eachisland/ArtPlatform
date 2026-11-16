using System;
using System.Collections.Generic;
using System.Text;

namespace ArtPlatformProject.Data.Entities
{
    namespace ArtPlatformProject.Data.Entities
    {
        public class UserPreference
        {
            public string UserId { get; set; } = "";
            public ApplicationUser User { get; set; } = null!;

            public int? PreferredCategoryId { get; set; }
            public Category? PreferredCategory { get; set; }

            public int? PreferredMoodId { get; set; }
            public Mood? PreferredMood { get; set; }

            public string? PreferredColor { get; set; }

            public bool RecommendationsEnabled { get; set; } = true;
        }
    }
}
