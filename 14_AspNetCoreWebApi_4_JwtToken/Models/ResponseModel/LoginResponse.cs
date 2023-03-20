namespace _14_AspNetCoreWebApi_4_JwtToken.Models.ResponseModel
{
    public class LoginResponse
    {
        public string AccessToken { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
