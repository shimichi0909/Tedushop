using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OdersDetails")]
    public class OdersDetail
    {
        [Key]
        public int OrderID { get; set; }
        [Key]
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }


    }
}