using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EAShop.Models
{
    [Table("promotion")]
    public partial class Promotion
    {
        [Key]
        [Column("promotion_id")]
        public Guid PromotionId { get; set; }
        [Column("promotion_product_id")]
        public Guid? PromotionProductId { get; set; }
        [Column("promotion_promotion")]
        public int? PromotionPromotion { get; set; }
        [Column("promotion_start_day", TypeName = "date")]
        public DateTime? PromotionStartDay { get; set; }
        [Column("promotion_end_date", TypeName = "date")]
        public DateTime? PromotionEndDate { get; set; }
        [Column("promotion_created_at", TypeName = "datetime")]
        public DateTime? PromotionCreatedAt { get; set; }
        [Column("promotion_updated_at", TypeName = "datetime")]
        public DateTime? PromotionUpdatedAt { get; set; }

        [ForeignKey(nameof(PromotionProductId))]
        [InverseProperty(nameof(Product.Promotion))]
        public virtual Product PromotionProduct { get; set; }
    }
}
