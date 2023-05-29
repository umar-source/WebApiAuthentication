using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiAuthentication.Models;
using WebApiAuthentication.Services;

namespace WebApiAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [AllowAnonymous]
        [HttpPost("Register")]
        public async Task<IActionResult> Register(LoginUser loginUser)
        {
            if (await _authService.RegisterUser(loginUser))
            {
                return Ok("Successfuly done");
            }
            return BadRequest("Something went worng");
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginUser loginUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (await _authService.LoginUser(loginUser))
            {
                var tokenString = _authService.GenerateTokenString(loginUser);

                return Ok(tokenString);
            }
            return BadRequest();
        }

        public async Task<IActionResult> Logout()
        {
            await _authService.LogoutUser();
            return Ok("User logged out successfully.");
        }
    }
}
