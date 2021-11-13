using Microsoft.Extensions.Logging;
using RatingEngineQouteAPI.Models;
using RatingEngineQuoteAPI.Repositories;
using System;
using System.Threading.Tasks;

namespace RatingEngineQuoteAPI.Services
{
    public class PremiumService : IPremiumService
    {
        readonly ILogger<PremiumService> _logger;
        readonly IStateRepository _stateRepository;
        readonly IBusinessRepository _businessRepository;

        //todo - defaults or initializers should go in the datastore or our appsettings.json file. Implement IOptions to inject into this class.
        const int _basePremiumDivisor = 1000;
        const int _hazardFactor = 4;

        decimal BasePremium(decimal revenue) => Math.Ceiling((revenue / _basePremiumDivisor));
    
        public PremiumService(ILogger<PremiumService> logger,
                              IStateRepository stateRepository,
                              IBusinessRepository businessRepository)
        {
            _logger = logger;
            _stateRepository = stateRepository;
            _businessRepository = businessRepository;
        }

        public async Task<decimal> CalculatePremium(decimal revenue, string stateName, string businessName)
        {
            StateModel stateModel = (await _stateRepository.GetStateByName(stateName) ?? throw new ArgumentException($"{nameof(stateName)} not found in db"));
            BusinessModel businessModel = (await _businessRepository.GetBusinessByName(businessName) ?? throw new ArgumentException($"{nameof(businessName)} not found in db"));
            
            return BasePremium(revenue) * _hazardFactor * stateModel.Factor * businessModel.Factor;
        }
    }
}
