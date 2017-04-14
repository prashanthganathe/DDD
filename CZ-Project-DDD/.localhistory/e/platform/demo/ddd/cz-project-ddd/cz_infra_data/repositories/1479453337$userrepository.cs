using AspNetIdentity.WebApi.Infrastructure;
using CZ.Domain.Entities;
using CZ.Domain.Interfaces.IRepositories;
using CZ.Infra.Data.Context;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using System.Web.Http;


using System;
using System.Net.Http;
using System.Web;
using Microsoft.Owin;




namespace CZ.Infra.Data.Repositories
{
    public static class OwinClass
    {
        public static IOwinContext GetOwinContext(this HttpRequestMessage request)
        {
            var context = request.Properties["MS_HttpContext"] as System.Web.HttpContextExtensions. HttpContextWrapper;
            if (context != null)
            {
                return HttpContextBaseExtensions.GetOwinContext(context.Request);
            }
            return null;
        }
    }

    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DomainContext context) : base(context)
        {
        }

       

        public User FindUser(User user)
        {
            // Db.Users.SingleOrDefault(u=>u.UserName==user.UserName && u.pass)
           var _userManager = new ApplicationUserManager( new UserStore<ApplicationUser>(new DomainContext()));
           return _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<UserManager<User>>();
            // Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
        }
    }
}
