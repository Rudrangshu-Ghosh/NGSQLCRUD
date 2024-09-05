using System.ComponentModel.DataAnnotations;

namespace AngularCRUD.Models
{
    public class Employee
    {
        [Key]
        public int Eid { get; set; }

        public string Ename { get; set; }

        public decimal Salary { get; set; }

        public DateTime Doj { get; set; }

        public int? Deptid { get; set; }  
        public ICollection<Skill> Skills { get; set; }
    }
}
