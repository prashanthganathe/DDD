using CZ.MVC.Views.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CZ.MVC.Controllers
{
    public class LoginController : Controller
    {




        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl) || returnUrl == null)
            {
                //var siteService = new SiteService();
                if (ModelState.IsValid)
                {
                    //var a = await UserManager.FindAsync(model.Email, model.Password);
                    if (a != null)
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
