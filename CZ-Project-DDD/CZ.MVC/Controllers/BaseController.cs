using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CZ.MVC.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override void ExecuteCore()
        {
            string culture;
            if (this.Session == null || this.Session["CurrentCulture"] == null)
            {
                culture = "en-US";
            }
            else
            {
                culture = this.Session["CurrentCulture"].ToString();
            }
            // calling CultureHelper class properties for setting  
           // CultureHelpers.CurrentCulture = culture;
            base.ExecuteCore();
        }

        /// <summary>
        /// Core Execute the CurrentCulture from beginform
        /// </summary>
        /// <param name="callback">callback</param>
        /// <param name="state">state</param>
        /// <returns></returns>
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {

            string userculture = null;
            if (this.Session == null || this.Session["CurrentCulture"] == null)
            {
                var userLanguages = Request.UserLanguages;
                if (userLanguages != null)
                {
                    foreach (var cul in userLanguages)
                    {
                        if (cul == "da")
                        {
                            userculture = "da-DK";
                            break;
                        }
                    }
                }
                else
                {
                    userculture = "en-US";
                }
                if (userculture == null)
                    userculture = "en-US";
            }
            else
            {
                userculture = Session["CurrentCulture"].ToString();
            }
           // CultureHelpers.CurrentCulture = userculture;
            return base.BeginExecuteCore(callback, state);
        }

        /// <summary>
        /// Booling disableAsyncsupport returns the false
        /// </summary>
        protected override bool DisableAsyncSupport
        {
            get { return false; }
        }
    }
}