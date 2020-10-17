using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class University
    {
        
        public int UniversityId { get; set; }
        [Required]
        [Display(Name ="University Name")]
        public string UniversityName { get; set; }
        public ICollection<UserUniversity> UserUniversity { get; set; }
    }
}
