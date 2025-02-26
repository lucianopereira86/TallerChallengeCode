using Infra.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LegacyCodeSnippet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private readonly IUserRepository _userRepository;

        public UserController(ILogger<UserController> logger, IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }


        [HttpGet]
        public async Task<string> HasUser([FromQuery] string userName)
        {
            var result = await _userRepository.GetUsers(userName);
            if (result.Count == 0)
                return "User not found.";
            else
                return $"Hello, {userName}";
        }
    }
}
