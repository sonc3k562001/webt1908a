using System;
using System.Collections.Generic;

namespace NewsPaper1.Models
{
    public partial class News
    {
        public News()
        {
            Post = new HashSet<Post>();
        }

        public int NewsId { get; set; }
        public string Sections { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }
}
