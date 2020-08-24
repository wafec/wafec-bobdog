using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Wafec.BobDog.Core.Common.Identity;

namespace Wafec.BobDog.Core.Common.Context.Identity
{
    public class JwtSerializer
    {
        private string _secret;
        private ASCIIEncoding _encoding;

        public JwtSerializer()
        {
            _encoding = new ASCIIEncoding();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            _secret = "ThisIsMySecret";
        }

        public string Serialize(User user)
        {
            string header = Convert.ToBase64String(_encoding.GetBytes(SerializeHeader()));
            string payload = Convert.ToBase64String(_encoding.GetBytes(SerializePayload(user)));
            string signed = SignHeaderAndPayload(header, payload);
            return $"{header}.{payload}.{signed}";
        }

        private string SerializeHeader()
        {
            return JsonSerializer.Serialize(new JwtHeader()
            {
                Algorithm = "HS256",
                TokenType = "JWT"
            });
        }

        private string SerializePayload(User user)
        {
            return JsonSerializer.Serialize(new JwtPayload()
            {
                Name = user.Username,
                Sequence = DateTime.Now.Ticks
            });
        }

        private string SignHeaderAndPayload(string header, string payload)
        {   
            var encoding = new ASCIIEncoding();
            string toSign = $"{header}.{payload}";
            using (HMACSHA256 hash = new HMACSHA256(encoding.GetBytes(_secret)))
            {
                var hashResult = hash.ComputeHash(encoding.GetBytes(toSign));
                return Convert.ToBase64String(hashResult);
            }
        }
    }
}
