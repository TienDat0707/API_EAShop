using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EAShop.Models
{
    [Table("order")]
    public partial class Order
    {
        public Order()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        [Key]
        [Column("order_id")]
        public Guid OrderId { get; set; }
        [Column("order_user_id")]
        public Guid? OrderUserId { get; set; }
        [Column("order_name_of_consignee")]
        [StringLength(150)]
        public string OrderNameOfConsignee { get; set; }
        [Column("order_address")]
        [StringLength(150)]
        public string OrderAddress { get; set; }
        [Column("order_phone")]
        [StringLength(50)]
        public string OrderPhone { get; set; }
        [Column("order_note", TypeName = "ntext")]
        public string OrderNote { get; set; }
        [Column("order_total_price")]
        public long? OrderTotalPrice { get; set; }
        [Column("order_status")]
        public int? OrderStatus { get; set; }
        [Column("order_created_at", TypeName = "datetime")]
        public DateTime? OrderCreatedAt { get; set; }
        [Column("order_updated_at", TypeName = "datetime")]
        public DateTime? OrderUpdatedAt { get; set; }

        [ForeignKey(nameof(OrderUserId))]
        [InverseProperty(nameof(User.Order))]
        public virtual User OrderUser { get; set; }
        [InverseProperty("OrderDetailOrder")]
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
