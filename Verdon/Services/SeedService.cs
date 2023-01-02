using Microsoft.AspNetCore.Identity;
using Verdon.Core.Base;

namespace Verdon.Services
{
    public class SeedService
    {
        public static void SeedData(UserManager<IdentityUser> userManager, RoleManager<Role> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }



        public static void SeedUsers
    (UserManager<IdentityUser> userManager)
        {

            if (userManager.FindByNameAsync
                  ("admin@gmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "admin@gmail.com";
                user.Email = "admin@gmail.com";
                user.EmailConfirmed = true;
                IdentityResult result = userManager.CreateAsync
                (user, "Solomon12!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }


            if (userManager.FindByNameAsync
                   ("olafire03@gmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "olafire03@gmail.com";
                user.Email = "olafire03@gmail.com";
                user.EmailConfirmed = true;
                IdentityResult result = userManager.CreateAsync
                (user, "Solomon12!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }



        public static void SeedRoles(RoleManager<Role> roleManager)
        {
            if (!roleManager.RoleExistsAsync
               ("User").Result)
            {
                Role role = new Role();
                role.Name = "User";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }


            if (!roleManager.RoleExistsAsync
                ("Admin").Result)
            {
                Role role = new Role();
                role.Name = "Admin";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync
               ("Teacher").Result)
            {
                Role role = new Role();
                role.Name = "Lecturer";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
        }

    }
}
