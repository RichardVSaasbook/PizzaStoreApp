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
    public class IngredientController : ApiController
    {
        private PizzaDataServiceClient pizzaDataService;

        public IngredientController() : base() {
            pizzaDataService = new PizzaDataServiceClient();
        }

        [HttpGet]
        public HttpResponseMessage List(string name) {
            name = name.ToLowerInvariant();
            object response;

            if (name == "cheese") {
                response = ListIngredients(pizzaDataService.ListCheeses());
            }
            else if (name == "crust") {
                response = ListIngredients(pizzaDataService.ListCrusts());
            }
            else if (name == "sauce") {
                response = ListIngredients(pizzaDataService.ListSauces());
            }
            else if (name == "topping") {
                response = ListIngredients(pizzaDataService.ListToppings());
            }
            else {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, response, "application/json");
        }

        public HttpResponseMessage Get(int id) {
            return Request.CreateResponse(HttpStatusCode.OK, Ingredient.FromDAO(pizzaDataService.GetIngredient(id)), "application/json");
        }

        private List<Ingredient> ListIngredients(IEnumerable<IngredientDAO> ingredientDAOs) {
            List<Ingredient> ingredients = new List<Ingredient>();

            foreach (IngredientDAO ingredientDAO in ingredientDAOs) {
                ingredients.Add(Ingredient.FromDAO(ingredientDAO));
            }

            return ingredients;
        }
    }
}
