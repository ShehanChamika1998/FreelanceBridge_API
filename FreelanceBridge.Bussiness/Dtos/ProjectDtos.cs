using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Dtos
{
    public class ProjectTask
    {
        public int ClientID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        [Range(0, 9999999999999999.99)] // Adjust the range as per your application's requirements
        public decimal Budget { get; set; }
        public string Deadline { get; set; }

        //public string Status { get; set; }
    }

    public class Project 
    {
        public int PID { get; set; }

        public string? Status { get; set; }
    }
}
