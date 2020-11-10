using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EAShop.Models
{
    [Table("import_order")]
    public partial class ImportOrder
    {
        public ImportOrder()
        {
            ImportOrderDetail = new HashSet<ImportOrderDetail>();
        }

        [Key]
        [Column("import_order_id")]
        public Guid ImportOrderId { get; set; }
        [Column("import_order_user_id")]
        public Guid? ImportOrderUserId { get; set; }
        [Column("import_order_name_of_consignee")]
        [StringLength(150)]
        public string ImportOrderNameOfConsignee { get; set; }
        [Column("import_order_supplier_id")]
        public Guid? ImportOrderSupplierId { get; set; }
        [Column("import_order_total_price")]
        public long? ImportOrderTotalPrice { get; set; }
        [Column("import_order_created_at", TypeName = "datetime")]
        public DateTime? ImportOrderCreatedAt { get; set; }

        [ForeignKey(nameof(ImportOrderUserId))]
        [InverseProperty(nameof(User.ImportOrder))]
        public virtual User ImportOrderUser { get; set; }
        [InverseProperty("ImportOrderDetailImportOrder")]
        public virtual ICollection<ImportOrderDetail> ImportOrderDetail { get; set; }
    }
}
