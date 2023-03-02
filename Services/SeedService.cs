using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Verdon.Core.Base;
using Verdon.Core.Dynamic;
using Verdon.Data;

namespace Verdon.Services
{
    public class SeedService
    {
        public static void SeedData(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext _db)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
            SeedDepartment(_db);
        }

        public static void SeedDepartment(ApplicationDbContext _db)
        {
            try
            {
                var list = _db.Department.ToListAsync();
                var departments = new List<string> {

                "Arabic",
                "Christian Religious Studies",
                "Islamic Religious Studies",
                "History & International Studies",
                "Music",
                "Theatre Arts",
                "Portuguese / English",
                "Arabic Education",
                "CRS Education",
                "Islamic Studies Education",
                "English Education",
                "French Education",
                "History Education",
                "Yoruba Education",
                "Biology Education",
                " Chemistry Education",
                "Mathematics Education",
                "Physics Education",
                "Physical & Health Education",
                "Health Education",
                "Computer Science Education",
                "Educational Technology",
                "Business Education",
                "Accounting Education",
                "Educational Management",
                "Geography Education",
                "Economics Education",
                "Political Science Education",
                "Law",
                "Agriculture",
                "Accounting",
                "Public Administration",
                "Marketing",
                "Banking & Finance",
                "Management Technology",
                "Industrial Relations and Personnel Management",
                "Insurance",
                "Mass Communication",
                "Biochemistry",
                "Botany",
                "Chemistry",
                "Fisheries & Aquatic Biology",
                "Mathematics",
                "Microbiology",
                "Physics",
                "Zoology",
                "Computer Science",
                "Medicine & Surgery",
                "Physiology",
                "Dentistry",
                "Nursing",
                "Geography & Planning",
                "Psychology",
                "Economics",
                "Political Science",
                "Sociology",
                "Transport",
                "Mechanical Engineering",
                "Electronics & Computer Engineering",
                "Chemical and Polymer Engineering"
            };
                departments.ForEach(async x =>
                {
                    var data = list.Result.Any(y => y.Name == x);
                    if (data == false)
                    {
                        var input = new Department { Name = x };
                        await _db.Department.AddAsync(input);
                    }
                });
                _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void SeedUsers
    (UserManager<User> userManager)
        {

            try
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
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }



        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            try 
            {
                if (!roleManager.RoleExistsAsync
          ("User").Result)
                {
                    var role = new IdentityRole();
                    role.Name = "User";
                    IdentityResult roleResult = roleManager.
                    CreateAsync(role).Result;
                }

                if (!roleManager.RoleExistsAsync
                   ("HOC").Result)
                {
                    var role = new IdentityRole();
                    role.Name = "HOC";
                    IdentityResult roleResult = roleManager.
                    CreateAsync(role).Result;
                }


                if (!roleManager.RoleExistsAsync
                    ("Admin").Result)
                {
                    var role = new IdentityRole();
                    role.Name = "Admin";
                    IdentityResult roleResult = roleManager.
                    CreateAsync(role).Result;
                }

                if (!roleManager.RoleExistsAsync
                   ("Lecturer").Result)
                {
                    var role = new IdentityRole();
                    role.Name = "Lecturer";
                    IdentityResult roleResult = roleManager.
                    CreateAsync(role).Result;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
