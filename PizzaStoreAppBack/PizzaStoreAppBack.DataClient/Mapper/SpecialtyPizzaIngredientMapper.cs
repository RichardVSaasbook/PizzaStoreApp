using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    public partial class Mapper {
        /// <summary>
        /// Map an SpecialtyPizzaIngredient to SpecialtyPizzaIngredientDAO.
        /// </summary>
        /// <param name="specialtyPizzaIngredient">The SpecialtyPizzaIngredient to map from.</param>
        /// <returns>The mapped SpecialtyPizzaIngredientDAO.</returns>
        public SpecialtyPizzaIngredientDAO MapToSpecialtyPizzaIngredientDAO(SpecialtyPizzaIngredient specialtyPizzaIngredient) {
            return new SpecialtyPizzaIngredientDAO {
                CreatedDate = specialtyPizzaIngredient.CreatedDate,
                Ingredient = MapToIngredientDAO(specialtyPizzaIngredient.Ingredient),
                SpecialtyPizza = MapToSpecialtyPizzaDAO(specialtyPizzaIngredient.SpecialtyPizza),
                UpdatedDate = specialtyPizzaIngredient.UpdatedDate
            };
        }

        /// <summary>
        /// Map an SpecialtyPizzaIngredientDAO to SpecialtyPizzaIngredient.
        /// </summary>
        /// <param name="specialtyPizzaIngredientDAO">The SpecialtyPizzaIngredientDAO to map from.</param>
        /// <returns>The mapped SpecialtyPizzaIngredient.</returns>
        public SpecialtyPizzaIngredient MapToSpecialtyPizzaIngredient(SpecialtyPizzaIngredientDAO specialtyPizzaIngredientDAO) {
            SpecialtyPizzaIngredient specialtyPizzaIngredient = data.FindSpecialtyPizzaIngredient(specialtyPizzaIngredientDAO.SpecialtyPizza.SpecialtyPizzaId,
                specialtyPizzaIngredientDAO.Ingredient.IngredientId);
            Ingredient ingredient = MapToIngredient(specialtyPizzaIngredientDAO.Ingredient);
            SpecialtyPizza specialtyPizza = MapToSpecialtyPizza(specialtyPizzaIngredientDAO.SpecialtyPizza);

            specialtyPizzaIngredient.CreatedDate = specialtyPizzaIngredientDAO.CreatedDate;
            specialtyPizzaIngredient.Ingredient = ingredient;
            specialtyPizzaIngredient.IngredientId = ingredient.IngredientId;
            specialtyPizzaIngredient.SpecialtyPizza = specialtyPizza;
            specialtyPizzaIngredient.SpecialtyPizzaId = specialtyPizza.SpecialtyPizzaId;
            specialtyPizzaIngredient.UpdatedDate = specialtyPizzaIngredientDAO.UpdatedDate;

            return specialtyPizzaIngredient;
        }
    }
}