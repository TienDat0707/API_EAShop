using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_EAShop.Models
{
    [Table("slide")]
    public partial class Slide
    {
        [Key]
        [Column("slide_id")]
        public Guid SlideId { get; set; }
        [Column("slide_image")]
        [StringLength(150)]
        public string SlideImage { get; set; }
    }
}
