using GiveMe.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GiveMe.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GiveMe.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GiveMe.Models.ApplicationDbContext context)
        {
            var roleName = "Administrator";
            if (!context.Roles.Any(r => r.Name == roleName))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = roleName};

                manager.Create(role);
            }

            var email = "test2@example.com";
            if (!context.Users.Any(u => u.Email == email))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser
                {
                    UserName = email,
                    Email = email
                };
                manager.Create(user, "TestPassword123@");
                manager.AddToRole(user.Id, "Administrator");
            }

            context.SaveChanges();
        }
    }
}
