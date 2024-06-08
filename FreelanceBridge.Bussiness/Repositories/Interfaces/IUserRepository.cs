using FreelanceBridge.Bussiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> LoginAsync(string userName, string password);
        Task<UserReg> RegisterAsync(string userName, string password, string email);
        Task<dynamic> DeactivateUserAsync(string userName);
        Task<dynamic> AddUserAsaFreelancerAsync(string username, string profileDescription, decimal hourlyRate, string portfolioURL, decimal rating);
        Task<dynamic> AddUserAsaClientAsync(string username, string company, string companyDescription);
    }
}
