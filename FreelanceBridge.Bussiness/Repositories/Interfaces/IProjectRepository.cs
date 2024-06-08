using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Repositories.Interfaces
{
    public interface IProjectRepository
    {
        Task<dynamic> AddProjectAsync(int clientID, string title, string description, decimal budget, string deadline);
        Task<dynamic> SetProjectStatusAsync(int pID, string status);

        Task<dynamic> GetProjectsAsync(int pID, string status);
    }
}
