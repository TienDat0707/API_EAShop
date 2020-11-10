using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EAShop.Models
{
    [Table("order_detail")]
    public partial class OrderDetail
    {
        [Key]
        [Column("order_detail_order_id")]
        public Guid OrderDetailOrderId { get; set; }
        [Key]
        [Column("order_detail_product_id")]
        public Guid OrderDetailProductId { get; set; }
        [Column("order_detail_quantity")]
        public int? OrderDetailQuantity { get; set; }
        [Column("order_detail_price")]
        public long? OrderDetailPrice { get; set; }

        [ForeignKey(nameof(OrderDetailOrderId))]
        [InverseProperty(nameof(Order.OrderDetail))]
        public virtual Order OrderDetailOrder { get; set; }
        [ForeignKey(nameof(OrderDetailProductId))]
        [InverseProperty(nameof(Product.OrderDetail))]
        public virtual Product OrderDetailProduct { get; set; }
    }
}
