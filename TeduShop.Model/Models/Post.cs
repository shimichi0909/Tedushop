using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post : Audible
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "Varchar")]
        public string Alias { get; set; }

        [Required]
        public string CategoryID { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
        public string Content { get; set; }

        public bool HomeFlag { get; set; }
        public bool HotFlag { get; set; }
        public int ViewCount { get; set; }
        [ForeignKey("CategoryID")]
        public virtual PostCategorie PostCategorie { get; set; }
    }
}