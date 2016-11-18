using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PizzaStoreAppBack.DataAccess;

namespace PizzaStoreAppBack.DataClient {
    public class IngredientService : IIngredientService {
        private PizzaStoreAppData data;

        public IngredientService() {
            data = new PizzaStoreAppData();
        }

        /// <summary>
        /// List the cheese Ingredients available.
        /// </summary>
        /// <returns>The List of cheeses.</returns>
        public List<Ingredient> ListCheeses() {
            return data.ListCheeses();
        }

        /// <summary>
        /// List the crust Ingredients available.
        /// </summary>
        /// <returns>The List of crusts.</returns>
        public List<Ingredient> ListCrusts() {
            return data.ListCrusts();
        }

        /// <summary>
        /// List the sauce Ingredients available.
        /// </summary>
        /// <returns>The List of sauces.</returns>
        public List<Ingredient> ListSauces() {
            return data.ListSauces();
        }

        /// <summary>
        /// List the topping Ingredients available.
        /// </summary>
        /// <returns>The List of toppings.</returns>
        public List<Ingredient> ListToppings() {
            return data.ListToppings();
        }
    }
}
