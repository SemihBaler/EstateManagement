using AutoMapper;
using BusinessLayer.Abstract;
using CoreLayer.Dtos.CategoryDtos;
using CoreLayer.Responses.Results.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstateManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddAsync(AddCategoryDto entity)
        {
            var addedCategory = _mapper.Map<Category>(entity);
            var result=await _categoryService.AddAsync(addedCategory);
            return Ok(result);
        }
        [HttpPost("DeleteCategory")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _categoryService.DeleteAsync(id);
            return Ok(result);
        }
        [HttpPost("RemoveCategory")]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            var result = await _categoryService.RemoveAsync(id);
            return Ok(result);
        }
        [HttpPost("UpdateCategory")]
        public async Task<IActionResult> Update(UpdateCategoryDto entity)
        {
            var category = await _categoryService.GetByIdAsync(entity.CategoryId);
            var updateCategory = _mapper.Map<Category>(entity);
            var result = _categoryService.Update(updateCategory);
                return Ok(result);
        }
        [HttpGet("GetAllListCategory")]
        public async Task<IActionResult> GetAllListAsync()
        {
            var result = await _categoryService.GetAllListAsync();
            return Ok(result);
        }
        [HttpGet("GetByIdCategory")]
        public async Task<IActionResult> GetByIdCategoryAsync(int id)
        {
            var result = await _categoryService.GetByIdAsync(id);
            return Ok(result);
        }
    }
}
