using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategorie : Audible
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

        [MaxLength(500)]
        public string Description { get; set; }
        public int? ParentID { get; set; }
        public int? DisplayOrder { get; set; }
        [MaxLength(256)]
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
    }

  
}