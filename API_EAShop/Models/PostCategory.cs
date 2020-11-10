using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EAShop.Models
{
    [Table("post_category")]
    public partial class PostCategory
    {
        public PostCategory()
        {
            Post = new HashSet<Post>();
        }

        [Key]
        [Column("post_category_id")]
        public Guid PostCategoryId { get; set; }
        [Column("post_category_name")]
        [StringLength(150)]
        public string PostCategoryName { get; set; }
        [Column("post_category_description")]
        [StringLength(150)]
        public string PostCategoryDescription { get; set; }
        [Column("post_category_created_at", TypeName = "datetime")]
        public DateTime? PostCategoryCreatedAt { get; set; }
        [Column("post_category_updated_at", TypeName = "datetime")]
        public DateTime? PostCategoryUpdatedAt { get; set; }

        [InverseProperty("PostPostCategory")]
        public virtual ICollection<Post> Post { get; set; }
    }
}
