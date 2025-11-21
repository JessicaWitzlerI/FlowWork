using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Tarefas.Models;

namespace Tarefas.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel login)
        {
            if(login.Login == "admin" && login.Password == "admin")
            {
                var token = GerarTokenJWT();
                return Ok(new { token });
            }

            return BadRequest(new {mensagem = "Credenciais inválidas. Por favor, verifique seu nome de usuário e senha."});

        }

        private string GerarTokenJWT()
        {
            string chaveSecreta = "c2a0d4b0-95d2-4da2-aa2d-5086be1fb4f1";

            var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(chaveSecreta));
            var credencial = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim("login", "admin"),
                new Claim("name", "administrador do sistema")
            };

            var token = new JwtSecurityToken(
                issuer: "sua_empresa",
                audience: "sua_aplicacao",
                claims: null,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: credencial
                );

            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}
