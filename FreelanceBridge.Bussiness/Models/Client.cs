using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Models
{
    public class Client
    {
        public int Id { get; set; } 
        public string ClientName { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty ;
        public string CompanyDescription { get; set; } = string.Empty;
        public string ClientDescription { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
    }
}
