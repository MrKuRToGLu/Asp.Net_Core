using Microsoft.AspNetCore.Identity;

namespace _13_AspNetCoreApp.Models.Identity
{
    public class CustomError : IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = "1",
                Description = "Şfre En az 1 karakter küçük harf içermelidir"
            };
        }

        public override IdentityError InvalidEmail(string email)
        {
            return new IdentityError
            {
                Code = "2",
                Description = "Geçersiz Email"
            };
        }
    }
}
