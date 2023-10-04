using AutoMapper;
using BusinessLayer.Abstract;
using CoreLayer.Dtos.CategoryDtos;
using CoreLayer.Dtos.CustomerDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstateManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;


        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        [HttpPost("AddCustomer")]
        public async Task<IActionResult> AddAsync(AddCustomerDto entity)
        {
         var addedCustomer= _mapper.Map<Customer>(entity);
            var result = await _customerService.AddAsync(addedCustomer);
            return Ok(result);
        }
        [HttpPost("DeleteCustomer")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _customerService.DeleteAsync(id);
            return Ok(result);
        }
        [HttpPost("RemoveCustomer")]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            var result = await _customerService.RemoveAsync(id);
            return Ok(result);
        }
        [HttpPost("UpdateCustomer")]
        public async Task<IActionResult> Update(UpdateCustomerDto entity)
        {
            var category = await _customerService.GetByIdAsync(entity.CustomerId);
            var updatedCustomer = _mapper.Map<Customer>(entity);
            var result = _customerService.Update(updatedCustomer);
            return Ok(result);
        }
        [HttpGet("GetAllListCustomer")]
        public async Task<IActionResult> GetAllListAsync()
        {
            var result = await _customerService.GetAllListAsync();
            return Ok(result);
        }
        [HttpGet("GetByIdCustomer")]
        public async Task<IActionResult> GetByIdCustomerAsync(int id)
        {
            var result = await _customerService.GetByIdAsync(id);
            return Ok(result);
        }
    }
}
