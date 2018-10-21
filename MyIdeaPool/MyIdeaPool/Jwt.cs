using Microsoft.IdentityModel.Tokens;
using System;
using System.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace MyIdeaPool
{
    public class Jwt
    {
        public class Token
        {
            public string jwt { get; set; }
            public string refresh_token { get; set; }
        }

        private static string secret = "XCAP05H6LoKvbRRa/QkqLNMI7cOHguaRyHzyg7n5qEkGjQmtBhz4SzYh4Fqwjyi3KJHlSXKPwVu2+bXr6CtpgQ==";
        private static SymmetricSecurityKey securityKey;
        private static SymmetricSecurityKey Key {
            get {
                if (securityKey == null)
                {
                    byte[] key = Convert.FromBase64String(secret);
                    securityKey = new SymmetricSecurityKey(key);
                }
                return securityKey;
            }
        }
        private static SecurityTokenDescriptor Descriptor(string email)
        {
            return new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] {
                      new Claim("email", email)
                }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256Signature)
            };
        }
        public static string GenerateToken(string email)
        {
            var handler = new JwtSecurityTokenHandler();
            var token = handler.CreateJwtSecurityToken(Descriptor(email));
            return handler.WriteToken(token);
        }
        public static string DecodeToken(string jwt)
        {
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(jwt);
            return token.Claims.First(claim => claim.Type == "email").Value;
        }

        public static bool IsExpired(string jwt)
        {
            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(jwt);
            return DateTime.UtcNow > token.ValidTo;
        }
    }
}