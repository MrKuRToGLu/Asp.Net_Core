using _13_AspNetCoreApp.Models.ViewsModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _13_AspNetCoreApp.Controllers
{

    public class AccountController : Controller
    {
        UserManager<AppUser> userManager; // kullanıcıları yönetmek için kullanılır, kayıt vb. 
        SignInManager<AppUser> signInManager; // kulanıcı oturumunu yönetmek için kullanılır
        RoleManager<IdentityRole<int>> roleManager;
        public AccountController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole<int>> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserViewModel model)
        {

            AppUser user = await userManager.FindByNameAsync(model.UserName); // aspnetusers tablosuna insert işlemi yapar...

            if (user == null)
            {
                ModelState.AddModelError("mesaj", "Geçersiz Kulanıcı adı");
                return View();
            }

            var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("mesaj", $"Sayın {user.Name} Şifreniz hatalı.. Lütfen kontrol ediniz");
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync(); // cookie silinir. oturum kapalılır
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel model)
        {
            AppUser user = new AppUser();
            user.UserName = model.UserName;
            user.Name = model.Name;
            user.SurName = model.Surname;
            user.Email = model.Email;


            IdentityResult result = await userManager.CreateAsync(user, model.Password); // aspnetusers tablosuna insert işlemi yapar...

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                    ModelState.AddModelError(item.Code, item.Description);

                return View();
            }

            // rol kontrolü.. eğer role tanımlı değilse tanımla...
            if (!await roleManager.RoleExistsAsync("admin"))
            {
                await roleManager.CreateAsync(new IdentityRole<int>
                {
                    Name = "admin"
                });

                // kullanıcıya rolleri ata..
                if (user.UserName.Contains("eyildirim"))
                {
                    await userManager.AddToRoleAsync(user, "admin");
                }
            }

            if (!await roleManager.RoleExistsAsync("uye"))
            {
                await roleManager.CreateAsync(new IdentityRole<int>
                {
                    Name = "uye"
                });
            }

            await userManager.AddToRoleAsync(user, "uye");

            return RedirectToAction("Login"); // login action'a yönlendir...
        }
    }
}