using FreelanceBridge.Bussiness.Repositories.Interfaces;
using FreelanceBridge.Bussiness.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Services.Services
{
    public class SkillService : ISkillService
    {

        private readonly ISkillRepository _skillRepository;

        public SkillService(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }
        public async Task<dynamic> AddSkillFor2TblsAsync(string skillName, int freelancerID)
        {
            var res  = await _skillRepository.AddSkillFor2TblsAsync(skillName, freelancerID);
            return res;
        }

        public async Task<dynamic> AddSkillFromselectionAsync(int freelancerID, int SkillID)
        {
            var res =  await _skillRepository.AddSkillFromselectionAsync(freelancerID, SkillID);
            return res;
        }

        public async Task<dynamic> DeleteSkillAsync(int fSID)
        {
           var res = await _skillRepository.DeleteSkillAsync(fSID);
            return res;
        }

        public async Task<dynamic> GetSkillsAsync(int FID)
        {
           var res = await _skillRepository.GetSkillsAsync(FID);
            return res;
        }
    }
}
