using FreelanceBridge.Bussiness.Dtos;
using FreelanceBridge.Bussiness.Models;
using FreelanceBridge.Bussiness.Repositories.Interfaces;
using FreelanceBridge.Bussiness.Services.Interfaces;
using FreelanceBridge.Bussiness.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreelanceBridge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidsController : ControllerBase
    {

        private readonly IBidsService _Bidservice;

        public BidsController(IBidsService Bidservice)
        {
            _Bidservice = Bidservice;
        }

        [HttpPost("Bid_Creations")]
        public async Task<IActionResult> InsertBid([FromBody] BidRequest request)
        {
            var data = await _Bidservice.AddBidAsync(request);

            if (data == null)
            {
                return Unauthorized(new { message = "Failed to update!" });
            }

            return Ok(data);
        }
    }
}
