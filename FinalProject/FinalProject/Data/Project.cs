using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class Project
    {
        public int ProjectId { get; set; }
        [Display(Name ="Project Image")]
        [Required]
        public byte[] ProjectImage { get; set; }
        [Display(Name ="Project Name")]
        [Required]
        public string ProjectName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name ="Upload Project")]
        public byte[] uploadProject { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
    }
}
