using Dapper;
using FreelanceBridge.API.Models;
using System.Data;

namespace FreelanceBridge.API.Data
{
    public class UserRepository
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
    }
}
