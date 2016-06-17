using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication31.Controllers;

namespace MvcApplication31
{
    public class LogTrafficAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            TrafficManager.LogTraffic(filterContext.HttpContext.Request.UserAgent);
            base.OnActionExecuting(filterContext);
        }
    }
}