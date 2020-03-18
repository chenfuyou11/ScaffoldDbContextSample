using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldDbContextSample.Models
{
    public partial class Posts
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogBlogId { get; set; }
        public int? BlogId { get; set; }

        [ForeignKey(nameof(BlogId))]
        [InverseProperty(nameof(Blogs.Posts))]
        public virtual Blogs Blog { get; set; }
    }
}
