using FreelanceBridge.Bussiness.Dtos;
using FreelanceBridge.Bussiness.Repositories.Interfaces;
using FreelanceBridge.Bussiness.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreelanceBridge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly ISkillService _SkillService;

        public SkillsController(ISkillService SkillService)
        {
            _SkillService = SkillService;
        }

        [HttpPost("Skill_Creation")]
        public async Task<IActionResult> InsertSkill([FromBody] SkillTask request)
        {
            var data = await _SkillService.AddSkillFor2TblsAsync(request.SkillName, request.FreelanceId);

            if (data == null)
            {
                return Unauthorized(new { message = "Failed to update!" });
            }

            return Ok(data);
        }

        [HttpPost("Skill_Creation2")]
        public async Task<IActionResult> InsertSkillfromselection([FromBody] SkillTask2 request)
        {
            var data = await _SkillService.AddSkillFromselectionAsync(request.FreelanceId, request.SkillID);

            if (data == null)
            {
                return Unauthorized(new { message = "Failed to update!" });
            }

            return Ok(data);
        }

        [HttpPost("Skill_Delete")]
        public async Task<IActionResult> DeleteSkillfromselection(int id)
        {
            var data = await _SkillService.DeleteSkillAsync(id);

            if (data == null)
            {
                return Unauthorized(new { message = "Failed to update!" });
            }

            return Ok(data);
        }

        [HttpPost("Get_Skills")]
        public async Task<IActionResult> GetSkills([FromBody] Skill req)
        {
            var data = await _SkillService.GetSkillsAsync(req.FreelancerId);

            if (data == null)
            {
                return Unauthorized(new { message = "Failed to update!" });
            }

            return Ok(data);
        }
    }
}
