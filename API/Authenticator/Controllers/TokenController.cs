using Authenticator.Models;
using Authenticator.Models.Interfaces;
using Authenticator.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Authenticator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IJwtTokenManager _JwtTokenManager;
        public TokenController(IJwtTokenManager jwtTokenManager)
        {
            _JwtTokenManager = jwtTokenManager;
        }

        [HttpPost]
        public ActionResult<TokenResponse> Authenticate([FromBody] UserCredential credential)
        {
            if (!CredentialValidator.IsValid(credential))
                return new TokenResponse(StatusCodes.Status400BadRequest);

            var token = _JwtTokenManager.Authenticate(credential.UserName!, credential.Password!);

            if(string.IsNullOrEmpty(token))
                return new TokenResponse(StatusCodes.Status401Unauthorized);

            return new TokenResponse(StatusCodes.Status200OK,token);
        }
    }
}
