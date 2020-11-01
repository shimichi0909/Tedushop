using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("Products")]
    public class Product : Audible
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [maxlength(256)]
        public string Name { get; set; }
        [Required]
        [maxlength(256)]
        public string Alias { get; set; }
        [Required]
        public string CategoryID { get; set; }
        [maxlength(256)]
        public string Image { get; set; }
        public XElement MoreImages { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public int? Warranty { get; set; }
        [maxlength(500)]
        public string Description { get; set; }
        public string Content { get; set; }
        public bool HomeFlag { get; set; }
        public bool HotFlag { get; set; }
        public int? Viewcount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategorie GetProductCategorie { get; set; }
    }
}