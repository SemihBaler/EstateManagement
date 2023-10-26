using AutoMapper;
using BusinessLayer.Abstract;
using CoreLayer.Dtos.EstateDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstateManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateController : ControllerBase
    {
        private readonly IEstateService _estateService;
        private readonly IMapper _mapper;


        public EstateController(IEstateService estateService, IMapper mapper)
        {
            _estateService = estateService;
            _mapper = mapper;
        }

        [HttpPost("AddEstate")]
        public async Task<IActionResult> AddAsync(AddEstateDto entity)
        {
            var addedEstate = _mapper.Map<Estate>(entity);
            var result = await _estateService.AddAsync(addedEstate);
            return Ok(result);
        }
        [HttpPost("DeleteEstate")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _estateService.DeleteAsync(id);
            return Ok(result);
        }
        [HttpPost("RemoveEstate")]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            var result = await _estateService.RemoveAsync(id);
            return Ok(result);
        }
        [HttpPost("UpdateEstate")]
        public async Task<IActionResult> Update(UpdateEstateDto entity)
        {
            var estate = await _estateService.GetByIdAsync(entity.EstateId);
            var updatedEstate = _mapper.Map<Estate>(estate);
            var result = _estateService.Update(updatedEstate);
            return Ok(result);
        }
        [HttpGet("GetAllListEstate")]
        public async Task<IActionResult> GetAllListAsync()
        {
            var result = await _estateService.GetAllListAsync();
            return Ok(result);
        }
        [HttpGet("GetByIdEstate")]
        public async Task<IActionResult> GetByIdEstateAsync(int id)
        {
            var result = await _estateService.GetByIdAsync(id);
            return Ok(result);
        }
    }
}
