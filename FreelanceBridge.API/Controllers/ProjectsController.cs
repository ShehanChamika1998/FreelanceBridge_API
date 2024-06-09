using FreelanceBridge.Bussiness.Dtos;
using FreelanceBridge.Bussiness.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FreelanceBridge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpPost("Project_Creations")]
        public async Task<IActionResult> InsertProject([FromBody] ProjectTask request)
        {
            var data = await _projectService.AddProjectAsync(request.ClientID, request.Title, request.Description, request.Budget, request.Deadline);

            if (data == null)
            {
                return Unauthorized(new { message = "Failed to update!" });
            }

            return Ok(data);
        }

        [HttpPut("Project_Status_Update")]
        public async Task<IActionResult> UpdateProject([FromBody] Project request)
        {
            var data = await _projectService.SetProjectStatusAsync(request.PID, request.Status);

            if (data == null)
            {
                return Unauthorized(new { message = "No Data!" });
            }

            return Ok(data);
        }

        [HttpGet("Get_Projects")]
        public async Task<IActionResult> GetProject([FromBody] Project request)
        {
            var data = await _projectService.GetProjectsAsync(request.PID, request.Status);

            if (data == null)
            {
                return Unauthorized(new { message = "No Data!" });
            }

            return Ok(data);
        }

    }


}


