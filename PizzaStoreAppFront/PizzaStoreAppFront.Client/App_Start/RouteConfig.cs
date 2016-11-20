using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PizzaStoreAppFront.Client
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "",
                "person/order",
                new { controller = "Order", action = "Index" }
            );

            routes.MapRoute(
                "AddPizzaToCurrentOrder",
                "person/order/add-pizza",
                new { controller = "Order", action= "AddPizzaToCurrentOrder" }
            );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
