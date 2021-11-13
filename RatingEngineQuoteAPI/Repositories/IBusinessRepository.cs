using RatingEngineQouteAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RatingEngineQuoteAPI.Repositories
{
    // todo - Additional CRUD methods
    public interface IBusinessRepository
    {
        Task<IEnumerable<BusinessModel>> GetAllBusinesses();
        Task<BusinessModel> GetBusinessByName(string name);
    }
}
