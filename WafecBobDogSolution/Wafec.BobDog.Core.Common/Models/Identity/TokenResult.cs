using System;
using System.Collections.Generic;
using System.Text;

namespace Wafec.BobDog.Core.Common.Models.Identity
{
    public class TokenResult
    {
        public string Token { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiresIn { get; set; }
    }
}
