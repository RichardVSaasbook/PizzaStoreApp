using PizzaStoreAppFront.Domain.Models;
using PizzaStoreAppFront.Domain.PizzaDataServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PizzaStoreAppFront.ApiClient.Controllers {
    public class PeopleController : ApiController {
        private readonly PizzaDataServiceClient pizzaDataService;

        public PeopleController() {
            pizzaDataService = new PizzaDataServiceClient();
        }

        [HttpGet]
        public HttpResponseMessage List() {
            List<Person> people = new List<Person>();

            foreach (PersonDAO personDAO in pizzaDataService.ListPeople()) {
                people.Add(Person.FromDAO(personDAO));
            }

            return Request.CreateResponse(HttpStatusCode.OK, people, "application/json");
        }
    }
}
