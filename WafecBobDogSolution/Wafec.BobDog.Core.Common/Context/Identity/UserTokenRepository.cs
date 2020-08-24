using System;
using System.Collections.Generic;
using System.Text;
using Wafec.BobDog.Core.Common.Identity;

namespace Wafec.BobDog.Core.Common.Context.Identity
{
    public class UserTokenRepository
    {
        private readonly IdentityContext _identityContext;

        public UserTokenRepository(IdentityContext identityContext)
        {
            _identityContext = identityContext;
        }

        public UserToken Create(User user)
        {
            var jwtSerializer = new JwtSerializer();
            UserToken userToken = new UserToken()
            {
                User = user,
                CreatedAt = DateTime.Now,
                ExpiresIn = DateTime.Now.AddHours(2),
                Token = jwtSerializer.Serialize(user)
            };
            _identityContext.UserToken.Add(userToken);
            return userToken;
        }
    }
}
