/*using Microsoft.AspNetCore.Mvc;
using DroneX_API.Models;
using DroneX_API.Services;

namespace DroneX_API.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly MongoDbService _service;

        public AuthController(MongoDbService service)
        {
            _service = service;
        }

        // ================= SIGNUP =================
        [HttpPost("signup")]
        public IActionResult Signup([FromBody] SignupRequest request)
        {
            if (request.Password != request.ConfirmPassword)
            {
                return BadRequest(new ApiResponse
                {
                    Success = false,
                    Message = "Passwords do not match"
                });
            }

            if (_service.UserExists(request.Username))
            {
                return BadRequest(new ApiResponse
                {
                    Success = false,
                    Message = "Username already exists"
                });
            }

            _service.AddUser(request);

            return Ok(new ApiResponse
            {
                Success = true,
                Message = "User registered successfully"
            });
        }

        // ================= LOGIN =================
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var user = _service.GetUser(request.Username);

            if (user == null)
            {
                return Unauthorized(new ApiResponse
                {
                    Success = false,
                    Message = "User not found"
                });
            }

            bool valid = PasswordHelper.VerifyPassword(request.Password, user.PasswordHash);

            if (!valid)
            {
                return Unauthorized(new ApiResponse
                {
                    Success = false,
                    Message = "Incorrect password"
                });
            }

            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Login Successful"
            });
        }
    }
}*/
using Microsoft.AspNetCore.Mvc;
using DroneX_API.Models;
using DroneX_API.Services;
using DroneX_API.Helpers;

namespace DroneX_API.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly MongoDbService _service;

        public AuthController(MongoDbService service)
        {
            _service = service;
        }

        // ================= SIGNUP =================
        [HttpPost("signup")]
        public IActionResult Signup([FromBody] SignupRequest request)
        {
            if (request == null)
            {
                return BadRequest(new ApiResponse
                {
                    Success = false,
                    Message = "Invalid request"
                });
            }

            if (request.Password != request.ConfirmPassword)
            {
                return BadRequest(new ApiResponse
                {
                    Success = false,
                    Message = "Passwords do not match"
                });
            }

            if (_service.UserExists(request.Username))
            {
                return BadRequest(new ApiResponse
                {
                    Success = false,
                    Message = "Username already exists"
                });
            }

            var user = new User
            {
                Username = request.Username,
                PasswordHash = PasswordHelper.HashPassword(request.Password)
            };

            _service.AddUser(user);

            return Ok(new ApiResponse
            {
                Success = true,
                Message = "User registered successfully"
            });
        }

        // ================= LOGIN =================
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request == null)
            {
                return BadRequest(new ApiResponse
                {
                    Success = false,
                    Message = "Invalid request"
                });
            }

            var user = _service.GetUserByUsername(request.Username);

            if (user == null)
            {
                return Unauthorized(new ApiResponse
                {
                    Success = false,
                    Message = "User not found"
                });
            }

            bool valid = PasswordHelper.VerifyPassword(request.Password, user.PasswordHash);

            if (!valid)
            {
                return Unauthorized(new ApiResponse
                {
                    Success = false,
                    Message = "Incorrect password"
                });
            }

            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Login successful"
            });
        }
    }
}

