using PizzaStoreAppFront.Domain.Models;
using PizzaStoreAppFront.Domain.PizzaDataServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStoreAppFront.Api.Controllers
{
    public class SizeController : ApiController {
        private PizzaDataServiceClient pizzaDataService;

        public SizeController() : base() {
            pizzaDataService = new PizzaDataServiceClient();
        }

        public HttpResponseMessage Get(int id) {
            return Request.CreateResponse(HttpStatusCode.OK, Size.FromDAO(pizzaDataService.GetSize(id)), "application/json");
        }

        [HttpGet]
        public HttpResponseMessage List() {
            List<Size> sizes = new List<Size>();

            foreach (SizeDAO sizeDAO in pizzaDataService.ListSizes()) {
                sizes.Add(Size.FromDAO(sizeDAO));
            }

            return Request.CreateResponse(HttpStatusCode.OK, sizes, "application/json");
        }
    }
}
