using backend.Data;
using backend.DTO;
using backend.Infrstructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DataAccess dataAccess;
        private readonly TokenProvider tokenProvider;

        public AuthController(DataAccess dataAccess, TokenProvider tokenProvider)
        {
            this.dataAccess = dataAccess;
            this.tokenProvider = tokenProvider;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.Password);
            var result = dataAccess.RegisterUser(request.Email, hashedPassword, request.Role);

            return result ? Ok() : BadRequest();
        }

        [HttpPost]
        public ActionResult<AuthResponse> Login(AuthRequest request)
        {
            AuthResponse response = new AuthResponse();

            var user = dataAccess.FindUserByEmail(request.Email);
            if (user == null) return BadRequest("User not found");

            var verifyPassword = BCrypt.Net.BCrypt.Verify(request.Password, user.Password);
            if (!verifyPassword) return BadRequest("Invalid password");

            // Generate Access Token
            var token = tokenProvider.GenerateAccessToken(user);
            response.AccessToken = token;

            // Generate Refresh Token

            return response;
        }
    }
}
