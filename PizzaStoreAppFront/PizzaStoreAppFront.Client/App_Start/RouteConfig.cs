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
                null,
                "",
                new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                null,
                "person",
                new { controller = "Person", action = "Index" }
            );

            routes.MapRoute(
                null,
                "person/{personId}/order",
                new { controller = "Order", action = "Index" }
            );

            routes.MapRoute(
                null,
                "order-finish",
                new { controller = "Order", action = "Success" }
            );

            routes.MapRoute(
                "AddPizzaToCurrentOrder",
                "person/{personId}/order/add-pizza",
                new { controller = "Order", action = "AddPizzaToCurrentOrder" }
            );

            routes.MapRoute(
                "ClearOrder",
                "person/{personId}/order/clear",
                new { controller = "Order", action = "ClearOrder" }
            );

            routes.MapRoute(
                "SubmitOrder",
                "person/{personId}/order/submit",
                new { controller = "Order", action = "SubmitOrder" }
            );

            routes.MapRoute(
                null,
                "store",
                new { controller = "Store", action = "Index" }
            );

            routes.MapRoute(
                null,
                "store/{storeId}",
                new { controller = "Store", action = "Show" }
            );
        }
    }
}
