using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using TesteToken.Starter.Transacional;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Claims;
using Microsoft.Web.Services3.Security.Utility;
using Microsoft.IdentityModel.Tokens;

namespace TesteToken.Starter
{
    public class TesteTokenStarter
    {
        public static string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("asdasd123#123gasdhagsd");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Client_Id.ToString()),
                    new Claim(ClaimTypes.Authentication,user.Client_Secret.ToString())

                }),
                Expires= DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
