using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Dtos
{
    public class SkillTask
    {
        public int FreelanceId { get; set; }
        public string SkillName { get; set; }
    }

    public class SkillTask2
    {
        public int FreelanceId { get; set; }
        public int SkillID { get; set; }
    }

    public class Skill
    {
        public int FreelancerId { get; set; }
     
    }
}
