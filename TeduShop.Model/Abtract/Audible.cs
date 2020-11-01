using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abtract
{
    public abstract class Audible : IAuditable
    {
       public DateTime? CreatedDate { get; set; }
        [maxlength(256)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [maxlength(256)]
        public String UpdateBy { get; set; }
        [maxlength(256)]
        public string MetaKeyword { get; set; }
        [maxlength(256)]
        public string MetaDescription { get; set; }
        public bool Status { get; set; }
    }
}
