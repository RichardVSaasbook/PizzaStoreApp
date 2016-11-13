using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    public partial class Mapper {
        /// <summary>
        /// Map an PizzaIngredient to PizzaIngredientDAO.
        /// </summary>
        /// <param name="pizzaIngredient">The PizzaIngredient to map from.</param>
        /// <returns>The mapped PizzaIngredientDAO.</returns>
        public PizzaIngredientDAO MapToPizzaIngredientDAO(PizzaIngredient pizzaIngredient) {
            return new PizzaIngredientDAO {
                CreatedDate = pizzaIngredient.CreatedDate,
                Ingredient = MapToIngredientDAO(pizzaIngredient.Ingredient),
                Pizza = MapToPizzaDAO(pizzaIngredient.Pizza),
                UpdatedDate = pizzaIngredient.UpdatedDate
            };
        }

        /// <summary>
        /// Map an PizzaIngredientDAO to PizzaIngredient.
        /// </summary>
        /// <param name="pizzaIngredientDAO">The PizzaIngredientDAO to map from.</param>
        /// <returns>The mapped PizzaIngredient.</returns>
        public PizzaIngredient MapToPizzaIngredient(PizzaIngredientDAO pizzaIngredientDAO) {
            PizzaIngredient pizzaIngredient = data.FindPizzaIngredient(pizzaIngredientDAO.Pizza.PizzaId, pizzaIngredientDAO.Ingredient.IngredientId);
            Ingredient ingredient = MapToIngredient(pizzaIngredientDAO.Ingredient);
            Pizza pizza = MapToPizza(pizzaIngredientDAO.Pizza);

            pizzaIngredient.CreatedDate = pizzaIngredientDAO.CreatedDate;
            pizzaIngredient.Ingredient = ingredient;
            pizzaIngredient.IngredientId = ingredient.IngredientId;
            pizzaIngredient.Pizza = pizza;
            pizzaIngredient.PizzaId = pizza.PizzaId;
            pizzaIngredient.UpdatedDate = pizzaIngredientDAO.UpdatedDate;

            return pizzaIngredient;
        }
    }
}