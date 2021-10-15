using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Store.Application.DTOs;
using Store.Domain.Entities;
using Store.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Store.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService, IMapper mapper) : base(mapper)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            if (!user.IsValid())
                return BadRequest();

            await _userService.Create(user);

            return Created(nameof(Create), new { login = user.Login });
        }

        [HttpPost("Auth")]
        public async Task<IActionResult> Get([FromBody] UserDTO userDTO)
        {
            if (!_mapper.Map<User>(userDTO).IsValid())
                return BadRequest();

            var userToken = await _userService.Get(userDTO.Login, userDTO.Password);
            if (userToken == null)
                return NotFound(new {message = "Login or password is invalid" });

            return Ok(userToken);
        }
    }
}
