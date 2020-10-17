using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class Degree
    {
        public int DegreeId { get; set; }
        [Display(Name ="Degree Name")]
        [Required]
        public string DegreeName { get; set; }
        public ICollection<UserUniversity> UserUniversity { get; set; }

    }
}
