using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EAShop.Models
{
    [Table("comment")]
    public partial class Comment
    {
        [Key]
        [Column("comment_id")]
        public Guid CommentId { get; set; }
        [Column("comment_user_id")]
        public Guid? CommentUserId { get; set; }
        [Column("comment_product_id")]
        public Guid? CommentProductId { get; set; }
        [Column("comment_content", TypeName = "ntext")]
        public string CommentContent { get; set; }
        [Column("comment_created_at", TypeName = "datetime")]
        public DateTime? CommentCreatedAt { get; set; }

        [ForeignKey(nameof(CommentProductId))]
        [InverseProperty(nameof(Product.Comment))]
        public virtual Product CommentProduct { get; set; }
        [ForeignKey(nameof(CommentUserId))]
        [InverseProperty(nameof(User.Comment))]
        public virtual User CommentUser { get; set; }
    }
}
