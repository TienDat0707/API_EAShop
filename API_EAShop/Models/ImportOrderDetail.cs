using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EAShop.Models
{
    [Table("import_order_detail")]
    public partial class ImportOrderDetail
    {
        [Column("import_order_detail_import_order_id")]
        public Guid? ImportOrderDetailImportOrderId { get; set; }
        [Column("import_order_detail_product_id")]
        public Guid? ImportOrderDetailProductId { get; set; }
        [Column("import_order_detail_product_name")]
        [StringLength(150)]
        public string ImportOrderDetailProductName { get; set; }
        [Column("import_order_detail_quantity")]
        public int? ImportOrderDetailQuantity { get; set; }
        [Column("import_order_detail_price")]
        public long? ImportOrderDetailPrice { get; set; }

        [ForeignKey(nameof(ImportOrderDetailImportOrderId))]
        [InverseProperty(nameof(ImportOrder.ImportOrderDetail))]
        public virtual ImportOrder ImportOrderDetailImportOrder { get; set; }
        [ForeignKey(nameof(ImportOrderDetailProductId))]
        [InverseProperty(nameof(Product.ImportOrderDetail))]
        public virtual Product ImportOrderDetailProduct { get; set; }
    }
}
