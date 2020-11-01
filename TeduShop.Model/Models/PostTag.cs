using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    internal class PostTag
    {
        [Key]
        public int PostID { get; set; }
        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string Tagid { get; set; }
        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
        [ForeignKey("Tagid")]
        public virtual Tag Tag { get; set; }
    }
}