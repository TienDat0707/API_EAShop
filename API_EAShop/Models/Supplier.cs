using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EAShop.Models
{
    [Table("supplier")]
    public partial class Supplier
    {
        public Supplier()
        {
            Product = new HashSet<Product>();
        }

        [Key]
        [Column("supplier_id")]
        public Guid SupplierId { get; set; }
        [Column("supplier_name")]
        [StringLength(150)]
        public string SupplierName { get; set; }
        [Column("supplier_address")]
        [StringLength(150)]
        public string SupplierAddress { get; set; }
        [Column("supplier_email")]
        [StringLength(50)]
        public string SupplierEmail { get; set; }
        [Column("supplier_phone")]
        [StringLength(50)]
        public string SupplierPhone { get; set; }
        [Column("supplier_created_at", TypeName = "datetime")]
        public DateTime? SupplierCreatedAt { get; set; }
        [Column("supplier_updated_at", TypeName = "datetime")]
        public DateTime? SupplierUpdatedAt { get; set; }

        [InverseProperty("ProductSupplier")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
