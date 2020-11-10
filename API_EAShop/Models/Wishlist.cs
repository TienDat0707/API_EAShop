using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EAShop.Models
{
    [Table("wishlist")]
    public partial class Wishlist
    {
        [Key]
        [Column("wishlist_id")]
        public Guid WishlistId { get; set; }
        [Column("wishlist_user_id")]
        public Guid? WishlistUserId { get; set; }
        [Column("wishlist_product_id")]
        public Guid? WishlistProductId { get; set; }
        [Column("wishlist_created_at", TypeName = "datetime")]
        public DateTime? WishlistCreatedAt { get; set; }

        [ForeignKey(nameof(WishlistProductId))]
        [InverseProperty(nameof(Product.Wishlist))]
        public virtual Product WishlistProduct { get; set; }
        [ForeignKey(nameof(WishlistUserId))]
        [InverseProperty(nameof(User.Wishlist))]
        public virtual User WishlistUser { get; set; }
    }
}
