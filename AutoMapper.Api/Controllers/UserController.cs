using AutoMapper.Api.Data;
using AutoMapper.Api.Dtos;
using AutoMapper.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UserController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]

        public async Task<IActionResult> CreateUser(UserDto userDto)
        {
            if (userDto == null)
            {
                return BadRequest("null ekan");
            }


            var user =_mapper.Map<User>(userDto);
            await _context.users.AddAsync(user);
            var result = await _context.SaveChangesAsync();
            return Ok(result);
        }
    }
}
