﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class UserTechnicalSkills
    {
        public User User { get; set; }
        public string UserId { get; set; } 
        public TechnicalSkill TechnicalSkill { get; set; }
        public int TechnicalSkillId { get; set; }
    }
}
