using System;
using System.Collections.Generic;
using System.Text;

namespace ArtPlatformProject.Data.Entities
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public ICollection<ArtworkTag> ArtworkTags { get; set; } = new List<ArtworkTag>();
    }
}
