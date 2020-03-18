using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaffoldDbContextSample.Models
{
    public partial class Myhistory
    {
        [Key]
        [StringLength(150)]
        public string MigrationId { get; set; }
        [Required]
        [StringLength(32)]
        public string ProductVersion { get; set; }
    }
}
