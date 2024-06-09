using FreelanceBridge.Bussiness.Dtos;
using FreelanceBridge.Bussiness.Services.Interfaces;
using FreelanceBridge.Bussiness.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreelanceBridge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {

        private readonly IReviewService _reviewservice;

        public ReviewsController(IReviewService reviewservice)
        {
            _reviewservice = reviewservice;
        }


        [HttpPost("Review_Creation")]
        public async Task<IActionResult> Review_Creation([FromBody] ReviewDto request)
        {
            var res = await _reviewservice.AddReviewAsync(request);

            if (res == null)
            {
                return Unauthorized(new { message = "Failed to update!" });
            }

            return Ok(res);
        }
    }
}
