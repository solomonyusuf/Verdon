using Microsoft.AspNetCore.Identity;
using Verdon.Core.Base;

namespace Verdon.Services
{
    public class SeedService
    {
        public static void SeedData(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }



        public static void SeedUsers
    (UserManager<User> userManager)
        {

            if (userManager.FindByNameAsync
                  ("admin@gmail.com").Result == null)
            {
                var user = new User();
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
                var user = new User();
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

            if (userManager.FindByNameAsync
                   ("lecturer@gmail.com").Result == null)
            {
                var user = new User();
                user.UserName = "lecturer@gmail.com";
                user.Email = "lecturer@gmail.com";
                user.EmailConfirmed = true;
                IdentityResult result = userManager.CreateAsync
                (user, "Solomon12!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Lecturer").Wait();
                }
            }

            if (userManager.FindByNameAsync
                   ("user@gmail.com").Result == null)
            {
                var user = new User();
                user.UserName = "user@gmail.com";
                user.Email = "user@gmail.com";
                user.EmailConfirmed = true;
                IdentityResult result = userManager.CreateAsync
                (user, "Solomon12!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "User").Wait();
                }
            }

            if (userManager.FindByNameAsync
                   ("hoc@gmail.com").Result == null)
            {
                var user = new User();
                user.UserName = "hoc@gmail.com";
                user.Email = "hoc@gmail.com";
                user.EmailConfirmed = true;
                IdentityResult result = userManager.CreateAsync
                (user, "Solomon12!").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "HOC").Wait();
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
               ("HOC").Result)
            {
                Role role = new Role();
                role.Name = "HOC";
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
               ("Lecturer").Result)
            {
                Role role = new Role();
                role.Name = "Lecturer";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
        }

    }
}
