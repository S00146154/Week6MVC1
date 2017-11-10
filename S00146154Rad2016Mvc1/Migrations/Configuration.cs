namespace S00146154Rad2016Mvc1.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<S00146154Rad2016Mvc1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "S00146154Rad2016Mvc1.Models.ApplicationDbContext";
        }

        protected override void Seed(S00146154Rad2016Mvc1.Models.ApplicationDbContext context)
        {
            var manager =
                 new UserManager<ApplicationUser>(
                     new UserStore<ApplicationUser>(context));

            var roleManager =
                new RoleManager<IdentityRole>(
                    new RoleStore<IdentityRole>(context));

            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "Admin" }
                );
            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "ClubAdmin" }
                );
            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "member" }
                );

            PasswordHasher ps = new PasswordHasher();

            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    UserName = "Admin",
                    Email = "s00146154@itsligo.ie",
                    EmailConfirmed = true,
                    dateJoined = DateTime.Now,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Firstname = "Joe",
                    Lastname = "Gouldie",
                    PasswordHash = ps.HashPassword("ILikeTrains")
                });

            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    UserName = "ITS FC Admin",
                    Email = "radp2016@outlook.com",
                    EmailConfirmed = true,
                    dateJoined = DateTime.Now,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    Firstname = "Rad",
                    Lastname = "Paulner",
                    PasswordHash = ps.HashPassword("radP2016$1")
                });
            context.SaveChanges();

            ApplicationUser admin = manager.FindByEmail("s00146154@itsligo.ie");
            if (admin != null)
            {
                manager.AddToRoles(admin.Id, new string[] { "Admin", "member", "ClubAdmin" });
            }

        }
    }
}