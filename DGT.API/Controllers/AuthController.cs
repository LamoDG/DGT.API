using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace DGT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult Login()
        {
            // Validadriamos a partir de un modelo enviado por paramentro al usuario
            // Asumimos que tenemos un usuario válido

            // Leemos el secret_key desde nuestro appsettings
            var secretKey = _configuration.GetValue<string>("SecretKey");
            var key = Encoding.ASCII.GetBytes(secretKey);

            IEnumerable<Claim> claimList = new List<Claim>();
            claimList.Append(new Claim(ClaimTypes.NameIdentifier, "13"));
            claimList.Append(new Claim(ClaimTypes.Email, "perefronteraluna@gmail.com"));

            var claims = new ClaimsIdentity(claimList);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claims,
                // Nuestro token va a durar un día
                Expires = DateTime.UtcNow.AddDays(1),
                // Credenciales para generar el token usando nuestro secretykey y el algoritmo hash 256
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var createdToken = tokenHandler.CreateToken(tokenDescriptor);

            return this.Ok(tokenHandler.WriteToken(createdToken));
        }

    }
}