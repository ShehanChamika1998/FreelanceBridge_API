using FreelanceBridge.Bussiness.Models;
using FreelanceBridge.Bussiness.Repositories.Interfaces;
using FreelanceBridge.Bussiness.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<dynamic> AddUserAsaClientAsync(string username, string company, string companyDescription)
        {
            var res = await _userRepository.AddUserAsaClientAsync(username, company, companyDescription);
            return res;
        }

        public async Task<dynamic> AddUserAsaFreelancerAsync(string username, string profileDescription, decimal hourlyRate, string portfolioURL, decimal rating)
        {
            var res =await _userRepository.AddUserAsaFreelancerAsync(username, profileDescription, hourlyRate, portfolioURL, rating);
            return res;
        }

        public async Task<dynamic> DeactivateUserAsync(string userName)
        {
            var res =await _userRepository.DeactivateUserAsync(userName);
            return res;
        }

        public async Task<User> LoginAsync(string userName, string password)
        {
            User res = new User();
            res =await _userRepository.LoginAsync(userName, password);
            return res;
        }

        public async Task<UserReg> RegisterAsync(string userName, string password, string email)
        {
            UserReg user = new UserReg();
            user = await _userRepository.RegisterAsync(userName,password, email);
            return user;
        }
    }
}
