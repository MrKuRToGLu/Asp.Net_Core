using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace _13_AspNetCoreApp.Models.Identity
{
    //public class AppIdentityDbContext : DbContext
    public class AppIdentityDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public AppIdentityDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<AppIdentityDbContext> options) : base(options)
        {
        }
    }
}

/*
	

 1) Nuget	Package Manager penceresidinden Microsoft.AspNetCore.Identity.EntityFrameworkCore package indirilir...

2) Bir adet dbcontext sınıfı oluşturulup IdentityDbContext sınıfıfından türetilir. Bu sınıf 
 
 
 */
