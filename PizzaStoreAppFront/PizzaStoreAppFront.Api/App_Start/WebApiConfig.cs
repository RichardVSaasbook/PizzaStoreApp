using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace PizzaStoreAppFront.ApiClient {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                "",
                "ingredients/{name}",
                new { controller = "Ingredient", action = "List", name = "crust" }
            );

            config.Routes.MapHttpRoute(
                "",
                "ingredient/{id}",
                new { controller = "Ingredient" }
            );

            config.Routes.MapHttpRoute(
                "",
                "size",
                new { controller = "Size", action = "List" }
            );

            config.Routes.MapHttpRoute(
                "",
                "size/{id}",
                new { controller = "Size" }
            );

            config.Routes.MapHttpRoute(
                "",
                "store",
                new { controller = "Store", action = "List" }
            );

            config.Routes.MapHttpRoute(
                "",
                "store/{storeId}/orders",
                new { controller = "Store", action = "ListOrders" }
            );

            config.Routes.MapHttpRoute(
                "",
                "people",
                new { controller = "People", action = "List" }
            );

            config.Routes.MapHttpRoute(
                "",
                "order",
                new { controller = "Order" }
            );

            config.Routes.MapHttpRoute(
                null,
                "order/{orderId}/pizzas",
                new { controller = "Order", action = "ListPizzas" }
            );
        }
    }
}
