using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Dtos
{
    public class BidRequest
    {
        public int ProjectID { get; set; }
        public int FreelancerID { get; set; }
        public decimal BidAmount { get; set; }
        public string Proposal { get; set; }
    }
}
