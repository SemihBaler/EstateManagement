using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstateManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }
        [HttpGet("GetAllCity")]
        public async Task<IActionResult> GetAllCity() 
        {
            var result = await _cityService.GetAllListAsync();
            return Ok(result);
        }
      
    }
}
