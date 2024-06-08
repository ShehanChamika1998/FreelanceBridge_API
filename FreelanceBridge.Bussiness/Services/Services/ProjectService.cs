using FreelanceBridge.Bussiness.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Services.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
                _projectRepository = projectRepository;
        }
        public async Task<dynamic> AddProjectAsync(int clientID, string title, string description, decimal budget, string deadline)
        {
            var res =await _projectRepository.AddProjectAsync(clientID, title, description, budget, deadline);
            return res;
        }

        public async Task<dynamic> GetProjectsAsync(int pID, string status)
        {
            var res = await _projectRepository.GetProjectsAsync(pID, status);
            return res;
        }

        public async Task<dynamic> SetProjectStatusAsync(int pID, string status)
        {
            var res = await _projectRepository.SetProjectStatusAsync(pID,status);
            return res;
        }
    }
}
