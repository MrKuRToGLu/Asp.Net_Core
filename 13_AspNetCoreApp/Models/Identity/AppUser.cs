using Microsoft.AspNetCore.Identity;

namespace _13_AspNetCoreApp.Models.Identity
{
	// ID alanı int tipinde olması için <int> kullanıyoruz...
	public class AppUser : IdentityUser<int>
	{
		public string? Name { get; set; }
		public string? SurName { get; set; }
		public string? Gender { get; set; }
		public DateTime? BirthDate { get; set; }
	}
}
