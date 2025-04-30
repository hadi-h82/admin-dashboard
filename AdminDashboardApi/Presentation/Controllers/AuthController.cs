using AdminDashboardApi.Application.Interfaces;
using AdminDashboardApi.Application.Services;
using AdminDashboardApi.Domain.Entities;
using AdminDashboardApi.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminDashboardApi.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly AuthService _authService;

        public AuthController(IUserRepository userRepository, AuthService authService)
        {
            _userRepository = userRepository;
            _authService = authService;
        }

        // Login method already implemented by you...

        // Register method
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterRequest request)
        {

            var existingUser = await _userRepository.GetAllAsync();
            if (existingUser.Any(u => u.Username == request.Username))
                return BadRequest("Username already taken");


            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.Password);

            var newUser = new User
            {
                Id = Guid.NewGuid(),
                Username = request.Username,
                PasswordHash = hashedPassword
            };

            await _userRepository.AddAsync(newUser);


            var token = await _authService.LoginAsync(request.Username, request.Password);

            if (string.IsNullOrEmpty(token))
                return Unauthorized("Invalid login attempt.");

            return Ok(new { Token = token });
        }





        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginRequest request)
        {
            var token = await _authService.LoginAsync(request.Username, request.Password);

            if (string.IsNullOrEmpty(token))
                return Unauthorized("Invalid username or password.");

            return Ok(new { Token = token });
        }
    }

}
