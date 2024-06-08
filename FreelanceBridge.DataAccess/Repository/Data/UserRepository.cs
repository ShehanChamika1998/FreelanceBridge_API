using Dapper;
using FreelanceBridge.Bussiness.Models;
using FreelanceBridge.Bussiness.Repositories.Interfaces;
using System.Data;

namespace FreelanceBridge.DataAccess.Data
{
    public class UserRepository: IUserRepository
    {
        private readonly DapperContext _context;

        public UserRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<User> LoginAsync(string userName, string password)
        {
            try
            {
                var query = "dbo.Sp_UserLogin";
                var parameters = new { UserName = userName, Password = password };

                using (var connection = _context.CreateConnection())
                {
                    var user = await connection.QueryFirstOrDefaultAsync<User>(query, parameters, commandType: CommandType.StoredProcedure);
                    if (user == null)
                    {
                        return null;
                    }
                    return user; // This will return null if no matching user is found
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<UserReg> RegisterAsync(string userName, string password, string email)
        {
            try
            {
                //string? uType = null;
                var query = "dbo.Sp_InsertUser";
                var parameters = new { Username = userName, Password = password ,  Email = email };

                using (var connection = _context.CreateConnection())
                {
                    var user = await connection.QueryFirstOrDefaultAsync<UserReg>(query, parameters, commandType: CommandType.StoredProcedure);
                    if (user == null)
                    {
                        return null;
                    }
                    return user; // This will return null if no matching user is found
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<dynamic> DeactivateUserAsync(string userName)
        {
            try
            {
                //string? uType = null;
                var query = "dbo.Sp_DeactivateUser";
                var parameters = new { Username = userName};

                using (var connection = _context.CreateConnection())
                {
                    var user = await connection.QueryFirstOrDefaultAsync<dynamic>(query, parameters, commandType: CommandType.StoredProcedure);
                    if (user == null)
                    {
                        return null;
                    }
                    return user; // This will return null if no matching user is found
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<dynamic> AddUserAsaFreelancerAsync(string username, string profileDescription, decimal hourlyRate, string portfolioURL, decimal rating)
        {
            try
            {
                //string? uType = null;
                var query = "dbo.Sp_InsertFreelancer";
                var parameters = new { Username = username, ProfileDescription = profileDescription, HourlyRate = hourlyRate, PortfolioURL= portfolioURL, Rating= rating };

                using (var connection = _context.CreateConnection())
                {
                    var user = await connection.QueryFirstOrDefaultAsync<dynamic>(query, parameters, commandType: CommandType.StoredProcedure);
                    if (user == null)
                    {
                        return null;
                    }
                    return user; // This will return null if no matching user is found
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<dynamic> AddUserAsaClientAsync(string username, string company, string companyDescription)
        {
            try
            {
                //string? uType = null;
                var query = "dbo.Sp_InsertClient";
                var parameters = new { Username = username, CompanyName = company, CompanyDescription = companyDescription };

                using (var connection = _context.CreateConnection())
                {
                    var user = await connection.QueryFirstOrDefaultAsync<dynamic>(query, parameters, commandType: CommandType.StoredProcedure);
                    if (user == null)
                    {
                        return null;
                    }
                    return user; // This will return null if no matching user is found
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
