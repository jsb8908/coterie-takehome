using System.Threading.Tasks;

namespace RatingEngineQuoteAPI.Services
{
    public interface IPremiumService
    {
        Task<decimal> CalculatePremium(decimal revenue, string stateName, string businessName);
    }
}
