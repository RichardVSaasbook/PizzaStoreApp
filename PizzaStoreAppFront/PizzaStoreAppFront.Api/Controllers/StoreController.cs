using PizzaStoreAppFront.Domain.PizzaDataServiceReference;
using PizzaStoreAppFront.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStoreAppFront.Api.Controllers {
    public class StoreController : ApiController {
        private PizzaDataServiceClient pizzaDataService;

        public StoreController() : base() {
            pizzaDataService = new PizzaDataServiceClient();
        }

        [HttpGet]
        public HttpResponseMessage List() {
            List<Store> stores = new List<Store>();

            foreach (StoreDAO storeDAO in pizzaDataService.ListStores()) {
                stores.Add(Store.FromDAO(storeDAO));
            }

            return Request.CreateResponse(HttpStatusCode.OK, stores, "application/json");
        }
    }
}
