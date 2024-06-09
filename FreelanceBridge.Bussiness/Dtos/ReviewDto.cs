using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Dtos
{
    public class ReviewDto
    {
        public int ProjectID { get; set; }
        public int Reviewer1ID { get; set; }
        public int Reviewer2ID { get; set; }
        public decimal Rating { get; set; }
        public string Comments { get; set; }

    }
}
