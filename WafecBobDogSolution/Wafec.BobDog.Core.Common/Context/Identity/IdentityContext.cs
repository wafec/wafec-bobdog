using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Wafec.BobDog.Core.Common.Identity;

namespace Wafec.BobDog.Core.Common.Context.Identity
{
    public class IdentityContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<UserToken> UserToken { get; set; }
        public DbSet<GroupRole> GroupRole { get; set; }
        public DbSet<GroupUser> GroupUser { get; set; }
    }
}
