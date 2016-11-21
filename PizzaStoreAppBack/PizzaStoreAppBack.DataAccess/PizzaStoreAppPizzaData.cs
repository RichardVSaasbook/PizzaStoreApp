﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppBack.DataAccess {
    public partial class PizzaStoreAppData {
        /// <summary>
        /// Submit an Order to a Customer's closest Store.
        /// </summary>
        /// <param name="customer">The Customer who is making the Order.</param>
        /// <param name="pizzas">The List of the List of Ingredients in each Pizza.</param>
        /// <param name="sizes">The List of Sizes for each Pizza.</param>
        /// <returns>True if the Order was successful.</returns>
        public bool SubmitOrder(Store store, Person customer, List<Pizza> pizzas, decimal subTotal, decimal taxTotal, decimal total) {
            Order order = new Order {
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                Active = true,
                Person = customer,
                CustomerId = customer.PersonId,
                Store = store
            };

            foreach (var pizza in pizzas) {
                List<Ingredient> ingredients = new List<Ingredient>();

                foreach (PizzaIngredient pizzaIngredient in pizza.PizzaIngredients) {
                    ingredients.Add(pizzaIngredient.Ingredient);
                }

                PizzaData pizzaData = CreatePizza(ingredients, pizza.Size);

                if (pizzaData == null) {
                    return false;
                }

                pizzaData.Pizza.Order = order;
            }

            order.SubTotal = subTotal;
            order.Tax = taxTotal;
            order.Total = total;

            db.Orders.Add(order);
            return db.SaveChanges() > 0;
        }

        /// <summary>
        /// List all of the Ingredients within a SpecialtyPizza.
        /// </summary>
        /// <param name="specialtyPizzaId">The ID of the SpecialtyPizza.</param>
        /// <returns>The List of Ingredients.</returns>
        public List<Ingredient> ListSpecialtyPizzaIngredients(int specialtyPizzaId) {
            SpecialtyPizza specialtyPizza = FindSpecialtyPizza(specialtyPizzaId);
            List<Ingredient> ingredients = new List<Ingredient>();

            foreach (SpecialtyPizzaIngredient specialtyPizzaIngredient in specialtyPizza.SpecialtyPizzaIngredients.Where(spi => spi.Active)) {
                ingredients.Add(specialtyPizzaIngredient.Ingredient);
            }

            return ingredients;
        }

        /// <summary>
        /// List the Pizzas within an Order.
        /// </summary>
        /// <param name="orderId">The Id of the Order to grab Pizzas from.</param>
        /// <returns>The List of Pizzas.</returns>
        public List<Pizza> ListPizzasInOrder(int orderId) {
            return db.Pizzas.Where(p => p.Active && p.OrderId == orderId).ToList();
        }

        /// <summary>
        /// Creates a Pizza and returns that Pizza along with its price.
        /// </summary>
        /// <param name="ingredients">The List of Ingredients for the Pizza.</param>
        /// <param name="size">The Size of the Pizza.</param>
        /// <returns>The Pizza and Price of that Pizza.</returns>
        private PizzaData CreatePizza(List<Ingredient> ingredients, Size size) {
            PizzaData pizzaData = PizzaFactory.BuildPizza(ingredients, size);

            if (pizzaData != null) {
                db.Pizzas.Add(pizzaData.Pizza);
                db.SaveChanges();
            }

            return pizzaData;
        }
    }
}
