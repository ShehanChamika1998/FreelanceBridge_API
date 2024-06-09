using FreelanceBridge.Bussiness.Repositories.Interfaces;
using FreelanceBridge.Bussiness.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Services.Services
{
    public class ReviewService :IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        public ReviewService(IReviewRepository reviewRepository) 
        { 
            _reviewRepository = reviewRepository;
        }

        public async Task<dynamic> AddReviewAsync(dynamic data)
        {
            var res  = await _reviewRepository.AddReviewAsync(data);
            return res;
        }
    }
}
