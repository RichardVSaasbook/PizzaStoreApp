﻿using PizzaStoreAppFront.Client.Models;
using PizzaStoreAppFront.Domain.Abstract;
using PizzaStoreAppFront.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreAppFront.Client.Controllers {
    public class OrderController : Controller {
        private IPizzaStoreRepository repository;

        public OrderController(IPizzaStoreRepository repository) {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult Index() {
            return View(new OrderViewModel {
                Ingredients = GetOrderIngredientsVM(),
                OrderDetails = GetOrderDetailsVM()
            });
        }

        [HttpPost]
        public RedirectResult AddPizzaToCurrentOrder(int size, int crust, int cheese, int sauce, int[] toppings) {
            if (Session["Order"] == null) {
                Session["Order"] = new Order {
                    Pizzas = new List<Pizza>(),
                    SubTotal = 0,
                    TaxTotal = 0,
                    Total = 0
                };
            }

            decimal price = 0;

            List<Ingredient> ingredients = new List<Ingredient>();

            Ingredient ingredientCrust = repository.GetIngredient(crust),
                ingredientCheese = repository.GetIngredient(cheese),
                ingredientSauce = repository.GetIngredient(sauce);
            Size sizeObject = repository.GetSize(size);

            price += ingredientCrust.Price;
            price += ingredientCheese.Price;
            price += ingredientSauce.Price;
            price += sizeObject.Price;

            ingredients.Add(ingredientCrust);
            ingredients.Add(ingredientCheese);
            ingredients.Add(ingredientSauce);

            if (toppings != null) {
                foreach (int topping in toppings) {
                    Ingredient i = repository.GetIngredient(topping);
                    ingredients.Add(i);
                    price += i.Price;
                }
            }

            (Session["Order"] as Order).SubTotal += price;
            (Session["Order"] as Order).TaxTotal += 0;
            (Session["Order"] as Order).Total = (Session["Order"] as Order).SubTotal + (Session["Order"] as Order).TaxTotal;

            (Session["Order"] as Order).Pizzas.Add(new Pizza {
                Ingredients = ingredients,
                Size = sizeObject,
                Price = price
            });

            return new RedirectResult("/pizzastore/person/order");
        }

        /// <summary>
        /// Create and return the OrderIngredientsViewModel.
        /// </summary>
        /// <returns>The OrderIngredientsViewModel.</returns>
        private OrderIngredientsViewModel GetOrderIngredientsVM() {
            return new OrderIngredientsViewModel {
                Sizes = SelectListItems(
                    repository.ListSizes(),
                    s => s.SizeId.ToString(),
                    s => s.Dimension + " Inch (" + s.Price.ToString("C") + ")"
                ),
                Cheeses = IngredientSelectListItems(repository.ListIngredients("cheese")),
                Crusts = IngredientSelectListItems(repository.ListIngredients("crust")),
                Sauces = IngredientSelectListItems(repository.ListIngredients("sauce")),
                Toppings = IngredientSelectListItems(repository.ListIngredients("topping"))
            };
        }

        private OrderDetailsViewModel GetOrderDetailsVM() {
            List<PizzaViewModel> pizzaViewModels = new List<PizzaViewModel>();
            decimal subTotal = 0,
                taxTotal = 0,
                total = 0;

            if (Session["Order"] != null) {
                Order order = Session["Order"] as Order;

                subTotal = order.SubTotal;
                taxTotal = order.TaxTotal;
                total = order.Total;

                foreach (Pizza pizza in order.Pizzas) {
                    List<string> ingredientNames = new List<string>();

                    foreach (Ingredient ingredient in pizza.Ingredients) {
                        ingredientNames.Add(ingredient.Name);
                    }

                    pizzaViewModels.Add(new PizzaViewModel {
                        Name = pizza.Size.Dimension + " Inch Custom Pizza",
                        Ingredients = ingredientNames,
                        Price = pizza.Price.ToString("C")
                    });
                }
            }

            return new OrderDetailsViewModel {
                Pizzas = pizzaViewModels,
                SubTotal = subTotal.ToString("C"),
                TaxTotal = taxTotal.ToString("C"),
                Total = total.ToString("C")
            };
        }

        /// <summary>
        /// Gets a List of Ingredients of a specified type.
        /// </summary>
        /// <param name="type">The type of Ingredients to get.</param>
        /// <returns>The List of Ingredients.</returns>
        //private List<Ingredient> GetListOfIngredients(string type) {
        //    HttpClient request = new HttpClient();
        //    HttpResponseMessage response = request.GetAsync("http://localhost/pizzastore/api/ingredients/" + type).Result;

        //    if (response.IsSuccessStatusCode) {
        //        var stream = response.Content.ReadAsStreamAsync().Result;
        //        var serializer = new DataContractJsonSerializer(typeof(List<Ingredient>));
        //        return serializer.ReadObject(stream) as List<Ingredient>;
        //    }

        //    return new List<Ingredient>();
        //}

        //private Ingredient GetIngredient(int id) {
        //    HttpClient request = new HttpClient();
        //    HttpResponseMessage response = request.GetAsync("http://localhost/pizzastore/api/ingredient/" + id).Result;

        //    if (response.IsSuccessStatusCode) {
        //        var stream = response.Content.ReadAsStreamAsync().Result;
        //        var serializer = new DataContractJsonSerializer(typeof(Ingredient));
        //        return serializer.ReadObject(stream) as Ingredient;
        //    }

        //    return new Ingredient();
        //}

        /// <summary>
        /// Create a List of SelectListItems from a List of Ingredients.
        /// </summary>
        /// <param name="ingredients">The List of Ingredients.</param>
        /// <returns>The List of SelectListItems.</returns>
        private List<SelectListItem> IngredientSelectListItems(IEnumerable<Ingredient> ingredients) {
            //List<SelectListItem> selectListItems = new List<SelectListItem>();

            //foreach (Ingredient ingredient in ingredients) {
            //    selectListItems.Add(new SelectListItem {
            //        Value = ingredient.IngredientId.ToString(),
            //        Text = ingredient.Name + " (" + ingredient.Price.ToString("C") + ")"
            //    });
            //}

            //return selectListItems;
            return SelectListItems(
                ingredients,
                i => i.IngredientId.ToString(),
                i => i.Name + " (" + i.Price.ToString("C") + ")"
            );
        }

        private List<SelectListItem> SelectListItems<T>(IEnumerable<T> list, Func<T, string> valueFn, Func<T, string> textFn) {
            List<SelectListItem> selectListItems = new List<SelectListItem>();

            foreach (T item in list) {
                selectListItems.Add(new SelectListItem {
                    Value = valueFn(item),
                    Text = textFn(item)
                });
            }

            return selectListItems;
        }
    }
}