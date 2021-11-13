using RatingEngineQouteAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingEngineQuoteAPI.Repositories
{
    public class BusinessRepository : IBusinessRepository
    {
        //todo - should be backed by a real data store
        static List<BusinessModel> businessModels = new List<BusinessModel>()
         {
                                    new BusinessModel()
                                    {
                                        Name = "Architect",
                                        Factor = 1.00m
                                    },
                                        new BusinessModel()
                                    {
                                        Name = "Plumber",
                                        Factor = .50m
                                    },
                                        new BusinessModel()
                                    {
                                        Name = "Programmer",
                                        Factor = 1.25m
                                    }};                       
        

        public async Task<IEnumerable<BusinessModel>> GetAllBusinesses()
        {
            return await Task.FromResult(businessModels);
        }

        public async Task<BusinessModel> GetBusinessByName(string name)
        {
            //obviously, not ideal w/ larger data or a real data store.
            return await Task.FromResult(businessModels.FirstOrDefault(businessModel => businessModel.Name.ToUpper().Trim() == name.ToUpper().Trim()));
        }
    }
}
