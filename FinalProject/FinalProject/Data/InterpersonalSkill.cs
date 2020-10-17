using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class InterpersonalSkill
    {
        public int InterpersonalSkillId { get; set; }
        [Display(Name ="Interpersonal Skill")]
        [Required]
        public string InterpersonalName { get; set; }
        public ICollection<UserSkills> UserSkills { get; set; }
    }
}
