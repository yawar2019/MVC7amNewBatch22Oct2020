using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyFirstMvcApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "Default1",
             url: "Bakery/Pizza/{Eid}",
             defaults: new { controller = "Student", action = "Index", Eid = UrlParameter.Optional }
         );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{Eid}",
                defaults: new { controller = "Student", action = "Index", Eid = UrlParameter.Optional }
            );
        }
    }
}
