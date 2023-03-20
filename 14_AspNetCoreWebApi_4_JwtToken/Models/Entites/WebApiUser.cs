using System;
using System.Collections.Generic;

namespace _14_AspNetCoreWebApi_4_JwtToken.Models.Entites
{
    public partial class WebApiUser
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? FirmName { get; set; }
        public string? ContactName { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
