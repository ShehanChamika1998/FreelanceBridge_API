using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Dtos
{
    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class UserRegRequest
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }

    }

    public class DeactivateUsertRequest
    {
        public string Username { get; set; }

    }

    public class FreelancerRequest
    {

        public string Username { get; set; }
        public string ProfileDescription { get; set; }

        [Range(0, 9999999999.99)]
        public decimal HourlyRate { get; set; }
        public string PortfolioURL { get; set; }

        [Range(0, 5)]
        public decimal Rating { get; set; }
    }

    public class ClientRequest
    {
        public string Username { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
    }
}
