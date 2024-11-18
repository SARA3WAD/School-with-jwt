using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Xml.Linq;

namespace WebApplication9
{
    public class Taken:ITaken
    {
        private readonly IConfiguration _configuration;

        public Taken(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetJwt()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken
                (
                    issuer : _configuration["Jwt:Issuere"],
                    audience: _configuration["Jwt:Audience"],
                    expires: DateTime.UtcNow.AddMinutes(30),
                    signingCredentials:creds,
                    claims: new[] {new Claim("Name","sara") }
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
