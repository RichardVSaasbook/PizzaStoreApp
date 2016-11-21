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
    public class OrderController : ApiController
    {
        private PizzaDataServiceClient pizzaDataService;

        public OrderController() {
            pizzaDataService = new PizzaDataServiceClient();
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] OrderData orderData) {
            List<PizzaDAO> pizzaDAOs = new List<PizzaDAO>();

            foreach (Pizza pizza in orderData.pizzas) {
                List<IngredientDAO> ingredientDAOs = new List<IngredientDAO>();

                foreach (Ingredient ingredient in pizza.Ingredients) {
                    ingredientDAOs.Add(new IngredientDAO {
                        IngredientId = ingredient.IngredientId
                    });
                }

                pizzaDAOs.Add(new PizzaDAO {
                    CreatedDate = DateTime.Now,
                    Ingredients = ingredientDAOs.ToArray(),
                    Size = new SizeDAO { SizeId = pizza.Size.SizeId },
                    UpdatedDate = DateTime.Now
                });
            }

            if (pizzaDataService.CreateOrder(orderData.storeId, orderData.customerId, pizzaDAOs.ToArray(), orderData.subTotal, orderData.taxTotal, orderData.total)) {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpGet]
        public HttpResponseMessage ListPizzas(int orderId) {
            List<Pizza> pizzas = new List<Pizza>();

            foreach (PizzaDAO pizzaDAO in pizzaDataService.ListPizzasInOrder(orderId)) {
                pizzas.Add(Pizza.FromDAO(pizzaDAO));
            }

            return Request.CreateResponse(HttpStatusCode.OK, pizzas, "application/json");
        }
    }
}
