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

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddAsync(AddCategoryDto entity)
        {
            var addedCategory = new Category()
            {
                Name = entity.Name,
            };
            var result=await _categoryService.AddAsync(addedCategory);
            return Ok(result);
        }
        [HttpPost("DeleteCategory")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _categoryService.DeleteAsync(id);
            return Ok(result);
        }
        [HttpPost("UpdateCategory")]
        public async Task<IActionResult> UpdateAsync(int id)
        {
            var result = await _categoryService.UpdateAsync(id);
            return Ok(result);
        }
        [HttpGet("GetAllListCategory")]
        public async Task<IActionResult> GetAllListAsync()
        {
            var result = await _categoryService.GetAllListAsync();
            return Ok(result);
        }
    }
}
