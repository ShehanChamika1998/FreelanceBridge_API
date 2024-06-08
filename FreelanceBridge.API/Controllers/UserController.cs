using FreelanceBridge.Bussiness.Dtos;
using FreelanceBridge.Bussiness.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace FreelanceBridge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var user = await _userService.LoginAsync(request.UserName, request.Password);

            if (user == null)
            {
                return Unauthorized(new { message = "Invalid Username or Password" });
            }

            return Ok(user);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegRequest request)
        {
            var user = await _userService.RegisterAsync(request.Username, request.Password,request.Email);

            if (user == null)
            {
                return Unauthorized(new { message = "Username already exists" });
            }

            return Ok(user);
        }

        [HttpPost("deactivate_user")]
        public async Task<IActionResult> Deactivate([FromBody] DeactivateUsertRequest request)
        {
            var user = await _userService.DeactivateUserAsync(request.Username);

            if (user == null)
            {
                return Unauthorized(new { message = "Username already exists" });
            }

            return Ok(user);
        }
        [HttpPost("freelancer_register")]
        public async Task<IActionResult> FreelancerReg([FromBody] FreelancerRequest request)
        {
            var user = await _userService.AddUserAsaFreelancerAsync(request.Username,request.ProfileDescription,request.HourlyRate,request.PortfolioURL,request.Rating);

            if (user == null)
            {
                return Unauthorized(new { message = "Failed to update!" });
            }

            return Ok(user);
        }

        [HttpPost("client_register")]
        public async Task<IActionResult> ClientReg([FromBody] ClientRequest request)
        {
            var user = await _userService.AddUserAsaClientAsync(request.Username, request.CompanyName, request.CompanyDescription);

            if (user == null)
            {
                return Unauthorized(new { message = "Failed to update!" });
            }

            return Ok(user);
        }
    }

 
}
