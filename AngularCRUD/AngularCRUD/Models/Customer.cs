using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularCRUD.Models
{
    public class Customer
    {
        [Key]
        public int Cid { get; set; }
        public string Cname { get; set; }
        public decimal Sal { get; set; }
        public DateTime Doj { get; set; }
        public string City { get; set; }

        // Foreign Key
        public int? Deptid { get; set; }

        [ForeignKey("Deptid")]
        public virtual Department? Dept { get; set; }
    }
}
