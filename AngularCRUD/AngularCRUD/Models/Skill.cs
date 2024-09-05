using System.ComponentModel.DataAnnotations;

namespace AngularCRUD.Models
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public string SkillDesc { get; set; }
    }
}
