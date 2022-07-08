using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopAssignment.Application.System.Users;
using ShopAssignment.ViewModels.System.Users.Request;

namespace ShopAssignment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;

        public UsersController(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _userService.Authenticate(request);

            if (string.IsNullOrEmpty(result.ResultObj))
            {
                return Unauthorized("User is invalid!");
            }
            var user = await _userService.GetByUserName(request.UserName);
            var refreshToken = user.RefreshToken;
            if (refreshToken == null || DateTime.Now >= user.RefreshTokenExpiryTime)
            {
                refreshToken = _userService.GenerateRefreshToken();
            }

            var RefreshTokenValidityInDays = int.Parse(_configuration["Tokens:RefreshTokenVailidityInDays"]);

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(RefreshTokenValidityInDays);
            var token = result.ResultObj;
            if (result.IsSuccessed)
                return Ok(new
                {
                    token,
                    RefreshToken = user.RefreshToken
                }) ;
            return Unauthorized();
        }
        [HttpGet("{username}")]
        public async Task<IActionResult> GetById(string username)
        {
            var user = await _userService.GetByUserName(username);
            if (user == null)
                return BadRequest("Cannot find product");
            return Ok(user);
        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _userService.Register(request);
            if (!result)
            {
                return BadRequest("Register is unsuccessful");
            }
            return Ok("Ok");
        }
    }
}