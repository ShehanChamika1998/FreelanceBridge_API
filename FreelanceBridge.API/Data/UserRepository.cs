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
                var query = "dbo.SP_UserLogin";
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
    }
}
