using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    public partial class Mapper {
        /// <summary>
        /// Map an Ingredient to IngredientDAO.
        /// </summary>
        /// <param name="ingredient">The Ingredient to map from.</param>
        /// <returns>The mapped IngredientDAO.</returns>
        public IngredientDAO MapToIngredientDAO(Ingredient ingredient) {
            return new IngredientDAO {
                CreatedDate = ingredient.CreatedDate,
                IngredientId = ingredient.IngredientId,
                Name = ingredient.Name,
                Price = ingredient.Price,
                Type = ingredient.Type,
                UpdatedDate = ingredient.UpdatedDate
            };
        }

        /// <summary>
        /// Map an IngredientDAO to Ingredient.
        /// </summary>
        /// <param name="ingredientDAO">The IngredientDAO to map from.</param>
        /// <returns>The mapped Ingredient.</returns>
        public Ingredient MapToIngredient(IngredientDAO ingredientDAO) {
            Ingredient ingredient = data.FindIngredient(ingredientDAO.IngredientId);

            ingredient.CreatedDate = ingredientDAO.CreatedDate;
            ingredient.IngredientId = ingredientDAO.IngredientId;
            ingredient.Name = ingredientDAO.Name;
            ingredient.Price = ingredientDAO.Price;
            ingredient.Type = ingredientDAO.Type;
            ingredient.UpdatedDate = ingredientDAO.UpdatedDate;

            return ingredient;
        }
    }
}