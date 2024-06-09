using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Services.Interfaces
{
    public interface IReviewService
    {
        Task<dynamic> AddReviewAsync(dynamic data);
    }
}
