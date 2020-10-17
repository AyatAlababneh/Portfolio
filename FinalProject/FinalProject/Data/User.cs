using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class User:IdentityUser
    {
        
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Second Name")]
        public string SecondName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Display(Name = "Portfolio Email")]
        public string PortfolioEmail { get; set; }
        public bool Gender { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Personal Image")]
        public byte[] PersonalImage { get; set; }
        [Display(Name = "Major Name")]
        public string MajorName { get; set; }
        public string Vision { get; set; }
        public string About { get; set; }
        public byte[] CV { get; set; }

        public ICollection<UserSkills> UserSkills { get; set; }
        public ICollection<UserUniversity> UserUniversity { get; set; }
        public ICollection<Project> Project { get; set; }

    }
}
