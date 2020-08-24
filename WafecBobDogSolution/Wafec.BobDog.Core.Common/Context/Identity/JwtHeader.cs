using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Wafec.BobDog.Core.Common.Context.Identity
{
    public class JwtHeader
    {
        [JsonPropertyName("alg")]
        public string Algorithm { get; set; }
        [JsonPropertyName("typ")]
        public string TokenType { get; set; }
    }
}
