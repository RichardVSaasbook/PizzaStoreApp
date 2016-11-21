using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    public partial class Mapper {
        /// <summary>
        /// Map an Pizza to PizzaDAO.
        /// </summary>
        /// <param name="pizza">The Pizza to map from.</param>
        /// <returns>The mapped PizzaDAO.</returns>
        public PizzaDAO MapToPizzaDAO(Pizza pizza) {
            List<IngredientDAO> ingredientDAOs = new List<IngredientDAO>();

            foreach (PizzaIngredient pizzaIngredient in pizza.PizzaIngredients) {
                ingredientDAOs.Add(MapToIngredientDAO(pizzaIngredient.Ingredient));
            }

            return new PizzaDAO {
                CreatedDate = pizza.CreatedDate,
                Ingredients = ingredientDAOs,
                PizzaId = pizza.PizzaId,
                Size = MapToSizeDAO(pizza.Size),
                UpdatedDate = pizza.UpdatedDate
            };
        }

        /// <summary>
        /// Map an PizzaDAO to Pizza.
        /// </summary>
        /// <param name="pizzaDAO">The PizzaDAO to map from.</param>
        /// <returns>The mapped Pizza.</returns>
        public Pizza MapToPizza(PizzaDAO pizzaDAO) {
            Pizza pizza = data.FindPizza(pizzaDAO.PizzaId);
            Size size = MapToSize(pizzaDAO.Size);

            //List<PizzaIngredient> pizzaIngredients = new List<PizzaIngredient>();

            //foreach (IngredientDAO ingredient in pizzaDAO.Ingredients) {
            //    pizzaIngredients.Add(new PizzaIngredient {
            //        Ingredient = MapToIngredient(ingredient),
            //        Pizza = pizza
            //    });
            //}

            pizza.CreatedDate = pizzaDAO.CreatedDate;
            pizza.PizzaId = pizzaDAO.PizzaId;
            pizza.Size = size;
            pizza.SizeId = size.SizeId;
            pizza.UpdatedDate = pizzaDAO.UpdatedDate;
            //pizza.PizzaIngredients = pizzaIngredients;

            return pizza;
        }
    }
}