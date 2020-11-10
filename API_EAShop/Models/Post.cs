using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EAShop.Models
{
    [Table("post")]
    public partial class Post
    {
        [Key]
        [Column("post_id")]
        public Guid PostId { get; set; }
        [Column("post_name")]
        [StringLength(150)]
        public string PostName { get; set; }
        [Column("post_post_category_id")]
        public Guid? PostPostCategoryId { get; set; }
        [Column("post_content", TypeName = "ntext")]
        public string PostContent { get; set; }
        [Column("post_showonhome")]
        public bool? PostShowonhome { get; set; }
        [Column("post_created_at", TypeName = "datetime")]
        public DateTime? PostCreatedAt { get; set; }
        [Column("post_updated_at", TypeName = "datetime")]
        public DateTime? PostUpdatedAt { get; set; }

        [ForeignKey(nameof(PostPostCategoryId))]
        [InverseProperty(nameof(PostCategory.Post))]
        public virtual PostCategory PostPostCategory { get; set; }
    }
}
