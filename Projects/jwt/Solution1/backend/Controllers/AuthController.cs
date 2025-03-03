using backend.Data;
using backend.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DataAccess dataAccess;

        public AuthController(DataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.Password);
            var result = dataAccess.RegisterUser(request.Email, hashedPassword, request.Role);

            return result ? Ok() : BadRequest();
        }
    }
}
