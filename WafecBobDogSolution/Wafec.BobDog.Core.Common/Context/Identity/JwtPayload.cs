using System;
using System.Collections.Generic;
using System.Text;

namespace Wafec.BobDog.Core.Common.Context.Identity
{
    public class JwtPayload
    {
        public long Sequence { get; set; }
        public string Name { get; set; }
    }
}
