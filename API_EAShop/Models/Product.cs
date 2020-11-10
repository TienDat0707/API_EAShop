using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EAShop.Models
{
    [Table("product")]
    public partial class Product
    {
        public Product()
        {
            Comment = new HashSet<Comment>();
            ImportOrderDetail = new HashSet<ImportOrderDetail>();
            OrderDetail = new HashSet<OrderDetail>();
            Promotion = new HashSet<Promotion>();
            Wishlist = new HashSet<Wishlist>();
        }

        [Key]
        [Column("product_id")]
        public Guid ProductId { get; set; }
        [Column("product_name")]
        [StringLength(150)]
        public string ProductName { get; set; }
        [Column("product_supplier_id")]
        public Guid? ProductSupplierId { get; set; }
        [Column("product_product_category_id")]
        public Guid? ProductProductCategoryId { get; set; }
        [Column("product_sex")]
        public int? ProductSex { get; set; }
        [Column("product_import_price")]
        public long? ProductImportPrice { get; set; }
        [Column("product_price")]
        public long? ProductPrice { get; set; }
        [Column("product_quantity")]
        public int? ProductQuantity { get; set; }
        [Column("product_image")]
        [StringLength(50)]
        public string ProductImage { get; set; }
        [Column("product_more_image", TypeName = "xml")]
        public string ProductMoreImage { get; set; }
        [Column("product_description", TypeName = "ntext")]
        public string ProductDescription { get; set; }
        [Column("product_status")]
        public bool? ProductStatus { get; set; }
        [Column("product_showonhome")]
        public bool? ProductShowonhome { get; set; }
        [Column("product_created_at", TypeName = "datetime")]
        public DateTime? ProductCreatedAt { get; set; }
        [Column("product_updated_at", TypeName = "datetime")]
        public DateTime? ProductUpdatedAt { get; set; }

        [ForeignKey(nameof(ProductProductCategoryId))]
        [InverseProperty(nameof(ProductCategory.Product))]
        public virtual ProductCategory ProductProductCategory { get; set; }
        [ForeignKey(nameof(ProductSupplierId))]
        [InverseProperty(nameof(Supplier.Product))]
        public virtual Supplier ProductSupplier { get; set; }
        [InverseProperty("CommentProduct")]
        public virtual ICollection<Comment> Comment { get; set; }
        [InverseProperty("ImportOrderDetailProduct")]
        public virtual ICollection<ImportOrderDetail> ImportOrderDetail { get; set; }
        [InverseProperty("OrderDetailProduct")]
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        [InverseProperty("PromotionProduct")]
        public virtual ICollection<Promotion> Promotion { get; set; }
        [InverseProperty("WishlistProduct")]
        public virtual ICollection<Wishlist> Wishlist { get; set; }
    }
}
