using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace UI.WebAPI.Controllers
{
    [Route("Seguridad")]
    [ApiController]
    [Authorize]
    public class SeguridadController : ControllerBase
    {
        private IConfiguration _configuration;
        public SeguridadController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("ValidarUsuario")]
        public IActionResult ValidarUsuario([FromBody] Usuario usuario)
        {
            if (usuario == null)
                return BadRequest();

            if (usuario.UserName == "root" && usuario.Password == "123")
            {
                var Token = BuildToken(usuario);
                usuario.Token = Token;
                return Ok(usuario);
            }
            else
            {
                return NotFound();
            }
        }


        private string BuildToken(Usuario usuario)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Auth:Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.Name,usuario.UserName)
            };
            var token = new JwtSecurityToken(_configuration["Auth:Jwt:Issuer"],
                                            _configuration["Auth:Jwt:Audience"],
                                            claims,
                                            expires: DateTime.Now.AddMinutes(Convert.ToDouble(_configuration["Auth:Jwt:TokenExpirationMinutes"])),
                                            signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        public class Usuario
        {
            public string UserName { get; set; }
            public string Password { get; set; }
            public string Token { get; set; }
        }
    }
}
