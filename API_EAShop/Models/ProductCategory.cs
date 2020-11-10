using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EAShop.Models
{
    [Table("product_category")]
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Product = new HashSet<Product>();
        }

        [Key]
        [Column("product_category_id")]
        public Guid ProductCategoryId { get; set; }
        [Column("product_category_name")]
        [StringLength(150)]
        public string ProductCategoryName { get; set; }
        [Column("product_category_description")]
        [StringLength(150)]
        public string ProductCategoryDescription { get; set; }
        [Column("product_category_showonhome")]
        public bool? ProductCategoryShowonhome { get; set; }
        [Column("product_category_created_at", TypeName = "datetime")]
        public DateTime? ProductCategoryCreatedAt { get; set; }
        [Column("product_category_updated_at", TypeName = "datetime")]
        public DateTime? ProductCategoryUpdatedAt { get; set; }

        [InverseProperty("ProductProductCategory")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
