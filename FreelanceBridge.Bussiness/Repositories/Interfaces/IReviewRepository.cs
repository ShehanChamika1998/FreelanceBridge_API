using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        Task<dynamic> AddReviewAsync(dynamic data);
    }
}
