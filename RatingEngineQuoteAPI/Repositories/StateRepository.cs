using RatingEngineQouteAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingEngineQuoteAPI.Repositories
{
    public class StateRepository : IStateRepository
    {
        //todo - should be backed by a real data store
        static List<StateModel> stateModels = new List<StateModel>()
                                 {
                                    new StateModel()
                                    {
                                        Name = "OH",
                                        Factor = 1.000m
                                    },
                                        new StateModel()
                                    {
                                        Name = "FL",
                                        Factor = 1.200m
                                    },
                                        new StateModel()
                                    {
                                        Name = "TX",
                                        Factor = .943m
                                    }};

        public async Task<IEnumerable<StateModel>> GetAllStates()
        {
            return await Task.FromResult(stateModels);
        }

        public async Task<StateModel> GetStateByName(string name)
        {
            //obviously, not ideal w/ larger data or a real data store.
            return await Task.FromResult(stateModels.FirstOrDefault(businessModel => businessModel.Name.ToUpper().Trim() == name.ToUpper().Trim()));
        }
    }
}
