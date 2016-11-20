using PizzaStoreAppFront.Domain.SizeServiceReference;
using PizzaStoreAppFront.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStoreAppFront.Api.Controllers
{
    public class SizeController : ApiController {
        private SizeServiceClient sizeService;

        public SizeController() : base() {
            sizeService = new SizeServiceClient();
        }

        public HttpResponseMessage Get(int id) {
            return Request.CreateResponse(HttpStatusCode.OK, Size.FromDAO(sizeService.GetSize(id)), "application/json");
        }

        [HttpGet]
        public HttpResponseMessage List() {
            List<Size> sizes = new List<Size>();

            foreach (SizeDAO sizeDAO in sizeService.ListSizes()) {
                sizes.Add(Size.FromDAO(sizeDAO));
            }

            return Request.CreateResponse(HttpStatusCode.OK, sizes, "application/json");
        }
    }
}
