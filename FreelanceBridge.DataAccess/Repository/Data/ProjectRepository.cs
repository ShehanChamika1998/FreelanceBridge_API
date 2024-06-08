using Dapper;
using FreelanceBridge.Bussiness.Repositories.Interfaces;
using FreelanceBridge.DataAccess.Data;
using System.Data;

namespace FreelanceBridge.DataAccess.Data
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DapperContext _context;

        public ProjectRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<dynamic> AddProjectAsync(int clientID, string title, string description, decimal budget, string deadline)
        {
            try
                     
            {
                var query = "dbo.Sp_InsertProject";
                var parameters = new { ClientID = clientID, Title = title, Description = description, Budget = budget, Deadline = deadline, Status = "Open" };

                using (var connection = _context.CreateConnection())
                {
                    var data = await connection.QueryFirstOrDefaultAsync<dynamic>(query, parameters, commandType: CommandType.StoredProcedure);
                    if (data == null)
                    {
                        return null;
                    }
                    return data; // This will return null if no matching user is found
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<dynamic> GetProjectsAsync(int pID, string status)
        {
            try

            {
                var query = "dbo.Sp_GetProjects";
                object parameters = new { };
                // pID = pID == 0 ? null : pID;
                if (pID == 0 && status == "")
                {
                    parameters = new { };
                }
                if (pID == 0 && status != "")
                {
                    parameters = new { Status = status };
                }
                if (pID != 0 && status != "")
                {
                    parameters = new { PID = pID,Status = status };
                }
                if (pID != 0 && status == "")
                {
                    parameters = new { PID = pID};
                }

                using (var connection = _context.CreateConnection())
                {
                    var data = await connection.QueryAsync<dynamic>(query, parameters, commandType: CommandType.StoredProcedure);
                    if (data == null)
                    {
                        return null;
                    }
                    return data; // This will return null if no matching user is found
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<dynamic> SetProjectStatusAsync(int pID, string status)
        {
            try

            {
                var query = "dbo.Sp_UpdateProjectStatus";
                var statusText =  status  == "1" ? "InProgress" : "Close";
                var parameters = new { PID = pID, Status = statusText };

                using (var connection = _context.CreateConnection())
                {
                    var data = await connection.QueryFirstOrDefaultAsync<dynamic>(query, parameters, commandType: CommandType.StoredProcedure);
                    if (data == null)
                    {
                        return null;
                    }
                    return data; // This will return null if no matching user is found
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
