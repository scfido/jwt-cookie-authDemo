using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace AuthDemo
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationService()
        {
        }

        public string Authenticate(string userName, string password)
        {
            string token = string.Empty;
            
            var claims = new[]
            {
                new Claim(ClaimTypes.Name,userName)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1234567890abcdefg"));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var jwtToken = new JwtSecurityToken("http://localhost", "http://localhost", claims, expires: DateTime.Now.AddMinutes(30), signingCredentials: credentials);

            token = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            return token;
        }
    }
}
