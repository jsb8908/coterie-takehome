using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RatingEngineQuoteAPI.Dtos;
using RatingEngineQuoteAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RatingEngineQuoteAPI.Controllers
{
    //todo - auth
    [ApiController]
    [Route("api/[controller]")]
    public class PremiumController : ControllerBase
    {
        readonly ILogger<PremiumController> _logger;
        readonly IPremiumService _premiumService;

        public PremiumController(ILogger<PremiumController> logger,
                                 IPremiumService premiumService)
        {
            _logger = logger;
            _premiumService = premiumService;
        }

        //I'd prefer to Get(), using query parameters.
        [HttpPost("CalculatePremium")]
        [ProducesResponseType(typeof(decimal), 200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> CalculatePremium([FromBody] PremiumInputDto premiumInputDto)
        {
            //todo - validation on dto properties
            try
            {
                var result = await _premiumService.CalculatePremium(premiumInputDto.Revenue, premiumInputDto.State, premiumInputDto.Business);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            
            //todo - better messaging back to client on failures
            return BadRequest();
        }
    }
}
