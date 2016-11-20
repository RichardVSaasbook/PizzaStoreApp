using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;

namespace PizzaStoreAppBack.DataClient {
    public class IngredientService : IIngredientService {
        private PizzaStoreAppData data;
        private Mapper.Mapper mapper;

        public IngredientService() {
            data = new PizzaStoreAppData();
            mapper = new Mapper.Mapper(data);
        }

        /// <summary>
        /// List the cheese Ingredients available.
        /// </summary>
        /// <returns>The List of cheeses.</returns>
        public List<IngredientDAO> ListCheeses() {
            List<IngredientDAO> cheeses = new List<IngredientDAO>();

            foreach (Ingredient cheese in data.ListCheeses()) {
                cheeses.Add(mapper.MapToIngredientDAO(cheese));
            }

            return cheeses;
        }

        /// <summary>
        /// List the crust Ingredients available.
        /// </summary>
        /// <returns>The List of crusts.</returns>
        public List<IngredientDAO> ListCrusts() {
            List<IngredientDAO> crusts = new List<IngredientDAO>();

            foreach (Ingredient crust in data.ListCrusts()) {
                crusts.Add(mapper.MapToIngredientDAO(crust));
            }

            return crusts;
        }

        /// <summary>
        /// List the sauce Ingredients available.
        /// </summary>
        /// <returns>The List of sauces.</returns>
        public List<IngredientDAO> ListSauces() {
            List<IngredientDAO> sauaces = new List<IngredientDAO>();

            foreach (Ingredient sauce in data.ListSauces()) {
                sauaces.Add(mapper.MapToIngredientDAO(sauce));
            }

            return sauaces;
        }

        /// <summary>
        /// List the topping Ingredients available.
        /// </summary>
        /// <returns>The List of toppings.</returns>
        public List<IngredientDAO> ListToppings() {
            List<IngredientDAO> toppings = new List<IngredientDAO>();

            foreach (Ingredient topping in data.ListToppings()) {
                toppings.Add(mapper.MapToIngredientDAO(topping));
            }

            return toppings;
        }

        /// <summary>
        /// Gets a single Ingredient.
        /// </summary>
        /// <param name="ingredientId">The Ingredient to get.</param>
        /// <returns>The Ingredient which will contain no data if not found.</returns>
        public IngredientDAO GetIngredient(int ingredientId) {
            return mapper.MapToIngredientDAO(data.FindIngredient(ingredientId));
        }
    }
}
