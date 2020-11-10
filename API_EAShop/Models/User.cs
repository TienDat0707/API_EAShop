using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EAShop.Models
{
    [Table("user")]
    public partial class User
    {
        public User()
        {
            Comment = new HashSet<Comment>();
            ImportOrder = new HashSet<ImportOrder>();
            Order = new HashSet<Order>();
            Wishlist = new HashSet<Wishlist>();
        }

        [Key]
        [Column("user_id")]
        public Guid UserId { get; set; }
        [Column("user_name")]
        [StringLength(50)]
        public string UserName { get; set; }
        [Column("user_password")]
        [StringLength(50)]
        public string UserPassword { get; set; }
        [Column("user_full_name")]
        [StringLength(75)]
        public string UserFullName { get; set; }
        [Column("user_address")]
        [StringLength(150)]
        public string UserAddress { get; set; }
        [Column("user_email")]
        [StringLength(50)]
        public string UserEmail { get; set; }
        [Column("user_phone")]
        [StringLength(50)]
        public string UserPhone { get; set; }
        [Column("user_status")]
        public int? UserStatus { get; set; }
        [Column("user_created_at", TypeName = "datetime")]
        public DateTime? UserCreatedAt { get; set; }
        [Column("user_updated_at", TypeName = "datetime")]
        public DateTime? UserUpdatedAt { get; set; }

        [InverseProperty("CommentUser")]
        public virtual ICollection<Comment> Comment { get; set; }
        [InverseProperty("ImportOrderUser")]
        public virtual ICollection<ImportOrder> ImportOrder { get; set; }
        [InverseProperty("OrderUser")]
        public virtual ICollection<Order> Order { get; set; }
        [InverseProperty("WishlistUser")]
        public virtual ICollection<Wishlist> Wishlist { get; set; }
    }
}
