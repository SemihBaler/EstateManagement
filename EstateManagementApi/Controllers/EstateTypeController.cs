using AutoMapper;
using BusinessLayer.Abstract;
using CoreLayer.Dtos.EstateTypeDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstateTypeManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateTypeTypeController : ControllerBase
    {
        private readonly IEstateTypeService _estateTypeService;
        private readonly IMapper _mapper;


        public EstateTypeTypeController(IEstateTypeService estateTypeService, IMapper mapper)
        {
            _estateTypeService = estateTypeService;
            _mapper = mapper;
        }

        [HttpPost("AddEstateType")]
        public async Task<IActionResult> AddAsync(AddEstateTypeDto entity)
        {
            var addedEstateType = _mapper.Map<EstateType>(entity);
            var result = await _estateTypeService.AddAsync(addedEstateType);
            return Ok(result);
        }
        [HttpPost("DeleteEstateType")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _estateTypeService.DeleteAsync(id);
            return Ok(result);
        }
        [HttpPost("RemoveEstateType")]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            var result = await _estateTypeService.RemoveAsync(id);
            return Ok(result);
        }
        [HttpPost("UpdateEstateType")]
        public async Task<IActionResult> Update(UpdateEstateTypeDto entity)
        {
            var EstateType = await _estateTypeService.GetByIdAsync(entity.EstateTypeId);
            var updatedEstateType = _mapper.Map<EstateType>(EstateType);
            var result = _estateTypeService.Update(updatedEstateType);
            return Ok(result);
        }
        [HttpGet("GetAllListEstateType")]
        public async Task<IActionResult> GetAllListAsync()
        {
            var result = await _estateTypeService.GetAllListAsync();
            return Ok(result);
        }
        [HttpGet("GetByIdEstateType")]
        public async Task<IActionResult> GetByIdEstateTypeAsync(int id)
        {
            var result = await _estateTypeService.GetByIdAsync(id);
            return Ok(result);
        }
    }
}
