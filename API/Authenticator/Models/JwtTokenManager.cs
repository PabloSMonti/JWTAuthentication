using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Authenticator.Models.Interfaces;
using Authenticator.Tools;
using Microsoft.IdentityModel.Tokens;

namespace Authenticator.Models
{
    public class JwtTokenManager : IJwtTokenManager
    {
        private readonly IConfiguration _Config;
        public JwtTokenManager(IConfiguration config)
        {
            _Config = config;
        }

        public string Authenticate(string userName, string pass)
        {
            try
            {
                if (!Users.UsersData.Any(x => x.Name == userName && x.Password == pass))
                    return null!;

                byte[] keyBytes = SetupWizard.GetKeyBytes(_Config,"JwtConfig:Key");

                var tokenHandler = new JwtSecurityTokenHandler();

                var tokenDescriptor = new SecurityTokenDescriptor()
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier,userName)
                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);

                return tokenHandler.WriteToken(token);
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}