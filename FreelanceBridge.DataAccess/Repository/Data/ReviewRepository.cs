using Dapper;
using FreelanceBridge.Bussiness.Repositories.Interfaces;
using FreelanceBridge.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.DataAccess.Repository.Data
{
    public class ReviewRepository:IReviewRepository
    {
        private readonly DapperContext _context;
        public ReviewRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<dynamic> AddReviewAsync(dynamic data)
        {
            try

            {
                var query = "dbo.Sp_InsertReview";
                var parameters = new { ProjectID = data.ProjectID, Reviewer1ID = data.Reviewer1ID, Reviewer2ID = data.Reviewer2ID, Rating = data.Rating, Comments = data.Comments };

                using (var connection = _context.CreateConnection())
                {
                    var res = await connection.QueryFirstOrDefaultAsync<dynamic>(query, parameters, commandType: CommandType.StoredProcedure);
                    if (res == null)
                    {
                        return null;
                    }
                    return res; // This will return null if no matching user is found
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
