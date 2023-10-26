using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstateManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrictService _districtService;

        public DistrictController(IDistrictService districtService)
        {
            _districtService = districtService;
        }
        [HttpGet("GetAllDistrict")]
        public async Task<IActionResult> GetAllList()
        {
            var result = await _districtService.GetAllListAsync();
            return  Ok(result);

        }
    }
}
