using Dapper;
using FreelanceBridge.Bussiness.Repositories.Interfaces;
using FreelanceBridge.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.DataAccess.Repository.Data
{
    public class SkillRepository : ISkillRepository
    {
        private readonly DapperContext _context;

        public SkillRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<dynamic> AddSkillFor2TblsAsync(string skillName, int freelancerID)
        {
            try

            {
                var query = "dbo.Sp_InsertSkill";
                var parameters = new { SkillName = skillName, FreelancerID= freelancerID};

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

        public async Task<dynamic> AddSkillFromselectionAsync(int freelancerID, int SkillID)
        {
            try

            {
                var query = "dbo.Sp_InsertFreelancerSkill";
                var parameters = new { FreelancerID = freelancerID, SkillID = SkillID };

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

        public async Task<dynamic> DeleteSkillAsync(int fSID)
        {
            try

            {
                var query = "dbo.Sp_DeleteSkills";
                var parameters = new { FSID = fSID};

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

        public async Task<dynamic> GetSkillsAsync(int FID)
        {
            try

            {
                var query = "dbo.Sp_GetSkills";
                object parameters = new { };
            
                if (FID == 0 )
                {
                    parameters = new { };
                }
                if (FID != 0 )
                {
                    parameters = new { FID = FID };
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
    }
}
