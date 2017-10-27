namespace S00146154Rad2016Mvc1.Migrations
{
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
            /*
            context.Users.AddOrUpdate(u => u.UserName,
    new ApplicationUser
    {
        UserName = "Admin",
        Email = "JoeGouldie@College.ie",
        EmailConfirmed = true,
        JoinDate = DateTime.Now,
        SecurityStamp = Guid.NewGuid().ToString(),
        FirstName = "Paul",
        Surname = "Powell",
        PasswordHash = ps.HashPassword("Ppowell$1")
    });

            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    UserName = "ITS FC Admin",
                    Email = "radp2016@outlook.com",
                    EmailConfirmed = true,
                    dateJoined = DateTime.Now,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    FirstName = "Rad",
                    Surname = "Paulner",
                    PasswordHash = ps.HashPassword("radP2016$1")
                });
            context.SaveChanges();

            ApplicationUser admin = manager.FindByEmail("JoeGouldie1@College.ie");
            if (admin != null)
            {
                manager.AddToRoles(admin.Id, new string[] { "Admin", "member", "ClubAdmin" });
            }
            */
        }
    }
}