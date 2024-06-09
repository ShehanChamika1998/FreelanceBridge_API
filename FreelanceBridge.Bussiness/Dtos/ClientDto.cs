using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Dtos
{
    public class ClientDto
    {

        public class Client
        {
            public string Contact { get; set; } = string.Empty;
            public string CompanyName { get; set; } = string.Empty;
            public string CompanyDescription { get; set; } = string.Empty;
            public string ClientDescription { get; set; } = string.Empty;
        }
    }
}
