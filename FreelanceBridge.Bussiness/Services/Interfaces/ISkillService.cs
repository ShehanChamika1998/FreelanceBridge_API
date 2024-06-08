using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Services.Interfaces
{
    public interface ISkillService
    {
        Task<dynamic> AddSkillFor2TblsAsync(string skillName, int freelancerID);
        Task<dynamic> AddSkillFromselectionAsync(int freelancerID, int SkillID);
        Task<dynamic> DeleteSkillAsync(int fSID);
        Task<dynamic> GetSkillsAsync(int @FID);
    }
}
