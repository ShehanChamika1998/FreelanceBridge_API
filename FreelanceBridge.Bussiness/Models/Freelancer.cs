using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Models
{
    public class Freelancer
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string ProfileDescription { get; set; }

        [Range(0, 9999999999.99)]
        public decimal HourlyRate { get; set; }
        public string PortfolioURL { get; set; }

        [Range(0, 5)]
        public decimal Rating { get; set; }

    }
}
