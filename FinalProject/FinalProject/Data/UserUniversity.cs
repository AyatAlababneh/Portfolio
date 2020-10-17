using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class UserUniversity
    {
        public User User { get; set; }
        public string UserId { get; set; }
        public University University { get; set; }
        public int UniversityId { get; set; }
        public string major { get; set; }
        public Degree Degree { get; set; }
        public int DegreeId { get; set; }
    }
}
