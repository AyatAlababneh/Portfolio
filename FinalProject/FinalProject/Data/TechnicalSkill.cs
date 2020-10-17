using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class TechnicalSkill
    {
        public int TechnicalSkillId { get; set; }
        [Display(Name ="Technical Skill")]
        [Required]
        public string TechnicalName { get; set; }
        public ICollection<UserSkills> UserSkills { get; set; }
    }
}
