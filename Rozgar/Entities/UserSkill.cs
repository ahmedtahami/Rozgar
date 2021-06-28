using Rozgar.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rozgar.Entities
{
    public class UserSkill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FreelancerId { get; set; }
        [ForeignKey("FreelancerId")]
        public virtual ApplicationUser Freelancer { get; set; }
        public int SkillId { get; set; }
        [ForeignKey("SkillId")]
        public virtual Skill Skill { get; set; }
    }
}