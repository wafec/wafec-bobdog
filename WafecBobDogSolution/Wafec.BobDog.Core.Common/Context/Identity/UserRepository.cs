using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wafec.BobDog.Core.Common.Identity;

namespace Wafec.BobDog.Core.Common.Context.Identity
{
    public class UserRepository
    {
        private readonly IdentityContext _identityContext;

        public UserRepository(IdentityContext identityContext)
        {
            _identityContext = identityContext;
        }

        public User FindByUsernameAndPassword(string username, string password)
        {
            return _identityContext.User.Where(user => user.Username.Equals(username) && user.Password.Equals(password)).FirstOrDefault();
        }

        public bool ExistsByUsernameAndPassword(string username, string password)
        {
            return this.FindByUsernameAndPassword(username, password) != null;
        }

        public bool ExistsByUsername(string username)
        {
            return _identityContext.User.Any(user => user.Username.Equals(username));
        }
    }
}
