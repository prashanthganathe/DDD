using Application.Model;
using CZ.Domain.Entities;
using CZ.MVC.Views.Login;
using CZ_Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CZ.MVC.Controllers
{
    public class LoginController : BaseController
    {
        private readonly ILoginAppService _loginAppService;

        
        public LoginController(ILoginAppService loginAppService):base()
        {
            _loginAppService = loginAppService;
        }


        [AllowAnonymous]
        public ActionResult Index()
        {         
            return View("Login");
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public  ActionResult Login(UserView model, string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl) || returnUrl == null)
            {
             
                if (ModelState.IsValid)
                {
                    User user = new User { UserName = model.UserEmail, Password = model.Password };
                    var attemptedUser=  _loginAppService.ValidateUser(user);                 
                    if (attemptedUser != null)
                        return RedirectToAction("Authenticated");
                    else
                    {
                        return RedirectToAction("InvalidUser");
                    }
                }
                else
                {
                    return RedirectToAction("InvalidUser");
                }
            }

            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
    }
}
