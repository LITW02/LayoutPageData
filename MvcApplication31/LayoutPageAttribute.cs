using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication31.Controllers;

namespace MvcApplication31
{
    public class LayoutPageAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.Number = GetRandomNumber();
            filterContext.Controller.ViewBag.TrafficCount = TrafficManager.GetTrafficCount();
            //filterContext.Controller.ViewBag.UserName = filterContext.HttpContext.User.Identity.Name;
            base.OnActionExecuting(filterContext);
        }

        private int GetRandomNumber()
        {
            return new Random().Next(1, 100000);
        }
    }
}