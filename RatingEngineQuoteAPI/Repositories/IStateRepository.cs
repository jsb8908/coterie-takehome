using RatingEngineQouteAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RatingEngineQuoteAPI.Repositories
{
    // todo - Additional CRUD methods
    public interface IStateRepository
    {
        Task<IEnumerable<StateModel>> GetAllStates();
        Task<StateModel> GetStateByName(string name);
    }
}
