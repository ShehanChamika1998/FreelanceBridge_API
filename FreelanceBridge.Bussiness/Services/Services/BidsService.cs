using FreelanceBridge.Bussiness.Repositories.Interfaces;
using FreelanceBridge.Bussiness.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceBridge.Bussiness.Services.Services
{
    public class BidsService : IBidsService
    {

        private readonly IBidsRepository _bidsRepository;
        public BidsService(IBidsRepository bidsRepository)
        {
            _bidsRepository = bidsRepository;
        }
        public async Task<dynamic> AddBidAsync(dynamic data)
        {
            var res = await _bidsRepository.AddBidAsync(data);
            return res;
        }

    }
}
