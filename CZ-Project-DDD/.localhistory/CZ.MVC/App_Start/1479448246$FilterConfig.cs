using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Core.ActionFilters;

namespace CZ.MVC.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new GZipOrDeflateAttribute());
            filters.Add(new ActionSpeedProfilerAttribute());
            filters.Add(new CheckSessionOutAttribute());           

        }
    }
}