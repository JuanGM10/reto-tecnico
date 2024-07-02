using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using reto_tecnico_backend_api.BussinesLogic;
using reto_tecnico_backend_api.Entity;
using reto_tecnico_backend_api.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace reto_tecnico_backend_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        private readonly ILogicUsuario _iLogicUsuario;
        public LoginController(IConfiguration config, ILogicUsuario iLogicUsuario)
        {
            _config = config;
            _iLogicUsuario = iLogicUsuario;
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public  ResponseModel<Response> Login([FromBody]LoginModel model) 
        {

            var response = new ResponseModel<Response>();
            try
            {

                var result = _iLogicUsuario.LoginUsuario(model.Usuario, model.Password);
                var token = CrearToken(result.Item1);

                response.Data = new Response()
                {
                    Usuario = result.Item1,
                    Usuarios = result.Item2,
                    Token = token
                };
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Success = false;
            }
            return response;
        }


        private string CrearToken(UsuarioEntity model) 
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new Claim[]
            {
                new Claim("Usuario", model.Usuario),
                new Claim("Rol", model.Rol),
            };

            var Sectoken = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(60),
              signingCredentials: credentials);

            var token = new JwtSecurityTokenHandler().WriteToken(Sectoken);

            return token;
        }
    }
}
