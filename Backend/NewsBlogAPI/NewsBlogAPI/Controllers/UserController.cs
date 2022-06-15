using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsBlogAPI.Dto;
using NewsBlogAPI.Helpers;
using NewsBlogAPI.Models;

namespace NewsBlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserReposotory _repository;
        private readonly JwtService _jwtService;

        public UserController(IUserReposotory repository,JwtService jwtService)
        {
            _repository = repository;
            _jwtService = jwtService;
        }

        [HttpGet]
        public IActionResult getAllUser()
        {
            return Ok(_repository.getAllUser());
        }

        [HttpGet("{id}")]
        public IActionResult getUserBydId(int id)
        {
            return Ok(_repository.GetUserById(id));
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterDto dto)
        {
            var userUse = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password),
            };

            return Created("newUser", _repository.CreateUser(userUse));
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            var userFind = _repository.GetByEmail(dto.Email);

            if (userFind == null)
            {
                return BadRequest("Not Valid Email");
            }

            if (!BCrypt.Net.BCrypt.Verify(dto.Password,userFind.Password))
            {
                return BadRequest("Not Valid Password");
            }

            var jwt = _jwtService.Generate(userFind.Id);

            Response.Cookies.Append("jwt", jwt, new CookieOptions
            {
                HttpOnly = true,
            });

            return Ok(new
            {
                message = "Success"
            });
        }

        [HttpGet("getAccount")]
        public IActionResult UserLogin()
        {
            string jwt = Request.Cookies["jwt"];

            var token = _jwtService.Verify(jwt);

            var useId = int.Parse(token.Issuer);

            var userLoginHere = _repository.GetById(useId);

            if (userLoginHere == null)
            {
                return BadRequest("Not Found User");
            }

            return Ok(userLoginHere);
        }
    }
}
