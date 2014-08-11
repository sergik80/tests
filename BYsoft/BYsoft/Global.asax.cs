using BYsoft.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BYsoft
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
        }




        protected void Application_Error(object sender, EventArgs args)
        {
            Server.ClearError();
            Response.Clear();
            if (isAjaxRequest())
            {
                Response.Write("error");
            }
            else
            {
                Response.RedirectToRoute("ErrorRoute", new { action = "GlobalError" });
            }


        }

        private bool isAjaxRequest()
        {
            bool ajax = (Request["X-Requested-With"] == "XMLHttpRequest") ||
                 (Request.Headers != null && Request.Headers["X-Requested-With"] == "XMLHttpRequest");

            return ajax;
        }



    }
}
