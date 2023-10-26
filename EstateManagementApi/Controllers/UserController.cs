using AutoMapper;
using BusinessLayer.Abstract;
using CoreLayer.Dtos.CustomerDtos;
using CoreLayer.Dtos.UserDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstateManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;


        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("AddUser")]
        public async Task<IActionResult> AddAsync(AddUserDto entity)
        {
            var addedUser = _mapper.Map<User>(entity);
            var result = await _userService.AddAsync(addedUser);
            return Ok(result);
        }
        [HttpPost("DeleteUser")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _userService.DeleteAsync(id);
            return Ok(result);
        }
        [HttpPost("RemoveUser")]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            var result = await _userService.RemoveAsync(id);
            return Ok(result);                                                        
        }
        [HttpPost("UpdateUser")]
        public async Task<IActionResult> Update(UpdateUserDto entity)
        {
            var category = await _userService.GetByIdAsync(entity.UserId);
            var updatedUser = _mapper.Map<User>(entity);
            var result = _userService.Update(updatedUser);
            return Ok(result);
        }
        [HttpGet("GetAllListUser")]
        public async Task<IActionResult> GetAllListAsync()
        {
            var result = await _userService.GetAllListAsync();
            return Ok(result);
        }
        [HttpGet("GetByIdUser")]
        public async Task<IActionResult> GetByIdCustomerAsync(int id)
        {
            var result = await _userService.GetByIdAsync(id);
            return Ok(result);
        }
    }
}
