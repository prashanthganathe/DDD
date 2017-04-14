using CZ.Domain.Entities;
using CZ.Infra.Data.Context;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infra.Data.Migrations.seedData
{
    public class RoleSeed
    {
        public void RoleSeedData(DomainContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
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
           //

        }
    }
}
