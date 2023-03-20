using _14_AspNetCoreWebApi_4_JwtToken.Models.InputModel;
using _14_AspNetCoreWebApi_4_JwtToken.Models.Entites;
using _14_AspNetCoreWebApi_4_JwtToken.Models.ResponseModel;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;

namespace _14_AspNetCoreWebApi_4_JwtToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        NorthwindContext dbContext;
        public AuthenticationController(NorthwindContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = CheckUser(model);
            if (user == null)
            {
                return BadRequest("Kullanıcı bilgileri bulunamadı. Lütfen bilgileri kontrol ediniz");
            }


            LoginResponse response = CreateToken(user);
            return Ok(response);
        }

        private LoginResponse CreateToken(WebApiUser user)
        {
            LoginResponse retVal = new LoginResponse();

            DateTime tokenExpireDate = DateTime.Now.AddMinutes(1);
            string token = "";

            var tokenHandler = new JwtSecurityTokenHandler();

            string screetKey = "benbuservisinsecuritykeyiyim";

            var symetricKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(screetKey));
            var sigInCrediantel = new SigningCredentials(symetricKey, SecurityAlgorithms.HmacSha256Signature);

            var appClaim = new Claim[] {
                new Claim(JwtRegisteredClaimNames.Email,"client@demo.com"),
               // new Claim(JwtRegisteredClaimNames.Nbf,DateTime.Now.AddMinutes(2).ToString()),
                new Claim("username", user.UserName),
                new Claim("userid", user.Id.ToString()),
                new Claim("role","clientAdmin")
        };


            var jwtSecurityToken = new JwtSecurityToken(
                issuer: "JwtTokenServerApplication.com",
               // audience: user.FirmName,
                expires: tokenExpireDate,
                claims: appClaim,
                signingCredentials: sigInCrediantel
            );

            token = tokenHandler.WriteToken(jwtSecurityToken);

            retVal.AccessToken = token;
            retVal.ExpireDate = tokenExpireDate;

            return retVal;
        }

        // Not : üretilen token client tarafından request header'da Authorization key'i ile birlikte aşağıdaki gibi gönderilir;

        // Authorizatio = Bearer üretilentoken


        private WebApiUser CheckUser(LoginModel model)
        {
            WebApiUser user = dbContext.WebApiUsers.FirstOrDefault(c => c.UserName == model.UserName && c.Password == model.Password);

            return user;
        }
    }
}
