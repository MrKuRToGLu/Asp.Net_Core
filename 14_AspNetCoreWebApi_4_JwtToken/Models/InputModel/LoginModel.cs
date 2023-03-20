using System.ComponentModel.DataAnnotations;

namespace _14_AspNetCoreWebApi_4_JwtToken.Models.InputModel
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Şifre alanı zorunludur")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Şifre min. 3 max. 10 karakter gönderilemlidir")]
        public string Password { get; set; }
    }
}
