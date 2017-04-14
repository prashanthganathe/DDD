﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.IO.Compression;
using System.Net.Http;

namespace Web.Core.ActionFilters
{
    public class GZipOrDeflateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting
             (ActionExecutingContext filterContext)
        {
            string acceptencoding = filterContext.HttpContext.
                                    equest.Headers["Accept-Encoding"];

            if (!string.IsNullOrEmpty(acceptencoding))
            {
                acceptencoding = acceptencoding.ToLower();
                var response = filterContext.HttpContext.Response;
                if (acceptencoding.Contains("gzip"))
                {
                    response.AppendHeader("Content-Encoding", "gzip");
                    response.Filter = new GZipStream(response.Filter,
                                          CompressionMode.Compress);
                }
                else if (acceptencoding.Contains("deflate"))
                {
                    response.AppendHeader("Content-Encoding", "deflate");
                    response.Filter = new DeflateStream(response.Filter,
                                      CompressionMode.Compress);
                }
            }
        }
    }
}