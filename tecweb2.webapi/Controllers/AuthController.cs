using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using tecweb2.webapi.Businesses;
using tecweb2.webapi.Controllers.BaseController;
using tecweb2.webapi.Extensions.Attributes;
using tecweb2.webapi.Models.Payload;
using tecweb2.webapi.Models.Proxy;

namespace API.Controllers
{
    /// <summary>
    /// Controller for the auth.
    /// </summary>
    [Produces("application/json")]
    [Route("api/auth")]
    [ModelUser]
    [Authorize]
    public class AuthController : BaseController
    {
        private readonly AuthBusiness _authBusiness;

        public AuthController(AuthBusiness authBusiness)
        {
            _authBusiness = authBusiness;
        }

        /// <summary>
        ///     Logs in a user.
        /// </summary>
        /// <param name="loginPayload"></param>
        /// <response code="200">User logged in.</response>
        /// <response code="400">Missing or invalid param.</response>
        /// <response code="500">
        ///     We messed up somenthing and we aren't sure what, no system is perfect, check message for more
        ///     information.
        /// </response>
        /// <returns></returns>
        [ProducesResponseType(typeof(TokenProxy), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        [AllowAnonymous]
        [HttpPost]
        public Task<IActionResult> Login([FromBody] LoginPayload loginPayload)
        {
            return RunDefaultAsync( async () => Ok(await _authBusiness.Login(loginPayload)));
        }
        
    }
}