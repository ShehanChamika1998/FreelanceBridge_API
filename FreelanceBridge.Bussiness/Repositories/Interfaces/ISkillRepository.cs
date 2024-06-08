using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Repositories.Interfaces
{
    public interface ISkillRepository
    {
        Task<dynamic> AddSkillFor2TblsAsync(string skillName, int freelancerID);
        Task<dynamic> AddSkillFromselectionAsync(int freelancerID, int SkillID);
        Task<dynamic> DeleteSkillAsync(int FSID);
        Task<dynamic> GetSkillsAsync(int @FID);
    }
}
