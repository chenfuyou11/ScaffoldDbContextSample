using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldDbContextSample.Models
{
    public partial class Blogs
    {
        public Blogs()
        {
            Posts = new HashSet<Posts>();
        }

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rating { get; set; }
        public string XmlUrl { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public int BlogStatus { get; set; }
        [Column("BDateTime")]
        public DateTime BdateTime { get; set; }

        [InverseProperty("Blog")]
        public virtual ICollection<Posts> Posts { get; set; }
    }
}
