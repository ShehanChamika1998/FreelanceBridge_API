using FreelanceBridge.API.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace FreelanceBridge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var user = await _userRepository.LoginAsync(request.UserName, request.Password);

            if (user == null)
            {
                return Unauthorized(new { message = "Invalid Username or Password" });
            }

            return Ok(user);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegRequest request)
        {
            var user = await _userRepository.RegisterAsync(request.Username, request.Password,request.Email);

            if (user == null)
            {
                return Unauthorized(new { message = "Username already exists" });
            }

            return Ok(user);
        }

        [HttpPost("deactivate_user")]
        public async Task<IActionResult> Deactivate([FromBody] DeactivateUsertRequest request)
        {
            var user = await _userRepository.DeactivateUserAsync(request.Username);

            if (user == null)
            {
                return Unauthorized(new { message = "Username already exists" });
            }

            return Ok(user);
        }
    }

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
}
