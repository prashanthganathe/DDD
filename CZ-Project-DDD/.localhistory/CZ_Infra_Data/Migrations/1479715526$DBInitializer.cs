using AspNetIdentity.WebApi.Infrastructure;
using CZ.Infra.Data.Context;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infra.Data.Migrations
{
    public class DBInitializer : DropCreateDatabaseAlways<DomainContext>
    {
        protected override void Seed(DomainContext context)
        {   
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
            var user = new ApplicationUser()
            {
                UserName = "admin2",
                Email = "admin2@zeiss.com",
                EmailConfirmed = true,
                FirstName = "zeiss",
                LastName = "admin",
                //Level = 1,
                //JoinDate = DateTime.Now.AddYears(-3)
            };
            manager.Create(user, "Test123!");
            if (roleManager.Roles.Count() == 0)
            {
                roleManager.Create(new IdentityRole { Name = "DCPAdmin" });
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "Expert" });
                roleManager.Create(new IdentityRole { Name = "Front_Desk" });
                roleManager.Create(new IdentityRole { Name = "Site_Admin" });
                roleManager.Create(new IdentityRole { Name = "DCPMonitor" });
                roleManager.Create(new IdentityRole { Name = "RC_Site_Admin" });
                roleManager.Create(new IdentityRole { Name = "Web_Grader1" });
                roleManager.Create(new IdentityRole { Name = "Web_Grader2" });
                roleManager.Create(new IdentityRole { Name = "Web_Grader3" });
                roleManager.Create(new IdentityRole { Name = "Web_Expert" });
                roleManager.Create(new IdentityRole { Name = "GraderLevel1" });
                roleManager.Create(new IdentityRole { Name = "GraderLevel2" });
                roleManager.Create(new IdentityRole { Name = "GraderLevel3" });
                roleManager.Create(new IdentityRole { Name = "RC_Account_Admin" });
                roleManager.Create(new IdentityRole { Name = "AC_Site_Admin" });
                roleManager.Create(new IdentityRole { Name = "RC_Account_Admin" });
                roleManager.Create(new IdentityRole { Name = "AC_Account_Admin" });
                roleManager.Create(new IdentityRole { Name = "AC_Uploader" });
                roleManager.Create(new IdentityRole { Name = "Mass_Uploader" });
                roleManager.Create(new IdentityRole { Name = "Patient" });
                roleManager.Create(new IdentityRole { Name = "Prospect" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }
            var adminUser = manager.FindByName("admin");
          
            base.Seed(context);
            context.SaveChanges();
        }
    }
}
