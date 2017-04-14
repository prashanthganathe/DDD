using AspNetIdentity.WebApi.Infrastructure;
using CZ.Domain.Entities;
using CZ.Domain.Interfaces.IRepositories;
using CZ.Infra.Data.Context;
using Microsoft.AspNet.Identity.EntityFramework;

using System.Web.Http;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infra.Data.Repositories
{
    
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DomainContext context) : base(context)
        {
        }

       

        public User FindUser(User user)
        {
            // Db.Users.SingleOrDefault(u=>u.UserName==user.UserName && u.pass)
           var _userManager = new ApplicationUserManager( new UserStore<ApplicationUser>(new DomainContext()));
            return _userManager ??  Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
        }
    }
}
