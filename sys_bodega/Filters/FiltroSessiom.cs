using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sys_bodega.Models;
using sys_bodega.Controllers;

namespace sys_bodega.Filters
{
    public class FiltroSessiom : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var oDeportista = (Usuario)HttpContext.Current.Session["usuario"];
            if (oDeportista == null)
            {
                if (filterContext.Controller is LoginController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/Login/Index");
                }
            }
            else
            {
                if (filterContext.Controller is LoginController == true)
                {
                    filterContext.HttpContext.Response.Redirect("~/Home/Index");
                }
            }
            base.OnActionExecuting(filterContext);
        }

    }
}