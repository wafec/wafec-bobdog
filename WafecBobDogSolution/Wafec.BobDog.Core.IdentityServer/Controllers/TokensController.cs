using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Wafec.BobDog.Core.Common.Context.Identity;
using Wafec.BobDog.Core.Common.Models.Identity;

namespace Wafec.BobDog.Core.IdentityServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokensController : ControllerBase
    {
        private readonly IdentityContext _identityContext;
        private readonly UserRepository _userRepository;
        private readonly UserTokenRepository _userTokenRepository;

        public TokensController(IdentityContext identityContext,
            UserRepository userRepository,
            UserTokenRepository userTokenRepository)
        {
            this._identityContext = identityContext;
            this._userRepository = userRepository;
            this._userTokenRepository = userTokenRepository;
        }

        [HttpPost]
        public IActionResult Post(UserCredentialMessage userCredentialMessage) 
        {
            using var transaction = _identityContext.Database.BeginTransaction();
            var user = _userRepository.FindByUsernameAndPassword(
                userCredentialMessage.Username, 
                userCredentialMessage.Password);
            if (user != null)
            {
                var token = _userTokenRepository.Create(user);
                _identityContext.SaveChanges();
                transaction.Commit();
                return Ok(token);
            }
            else
            {
                return Unauthorized("Username or password invalid");
            }
        }
    }
}