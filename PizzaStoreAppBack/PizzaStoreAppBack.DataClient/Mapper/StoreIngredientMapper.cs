using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    public partial class Mapper {
        /// <summary>
        /// Map an StoreIngredient to StoreIngredientDAO.
        /// </summary>
        /// <param name=storeIngredient">The StoreIngredient to map from.</param>
        /// <returns>The mapped StoreIngredientDAO.</returns>
        public StoreIngredientDAO MapToStoreIngredientDAO(StoreIngredient storeIngredient) {
            return new StoreIngredientDAO {
                CreatedDate = storeIngredient.CreatedDate,
                Ingredient = MapToIngredientDAO(storeIngredient.Ingredient),
                Quantity = storeIngredient.Quantity,
                Store = MapToStoreDAO(storeIngredient.Store),
                UpdatedDate = storeIngredient.UpdatedDate
            };
        }

        /// <summary>
        /// Map an StoreIngredientDAO to StoreIngredient.
        /// </summary>
        /// <param name="storeIngredientDAO">The StoreIngredientDAO to map from.</param>
        /// <returns>The mapped StoreIngredient.</returns>
        public StoreIngredient MapToStoreIngredient(StoreIngredientDAO storeIngredientDAO) {
            StoreIngredient storeIngredient = data.FindStoreIngredient(storeIngredientDAO.Store.StoreId, storeIngredientDAO.Ingredient.IngredientId);
            Ingredient ingredient = MapToIngredient(storeIngredientDAO.Ingredient);
            Store store = MapToStore(storeIngredientDAO.Store);

            storeIngredient.CreatedDate = storeIngredientDAO.CreatedDate;
            storeIngredient.Ingredient = ingredient;
            storeIngredient.IngredientId = ingredient.IngredientId;
            storeIngredient.Quantity = storeIngredientDAO.Quantity;
            storeIngredient.Store = store;
            storeIngredient.StoreId = store.StoreId;
            storeIngredient.UpdatedDate = storeIngredientDAO.UpdatedDate;

            return storeIngredient;
        }
    }
}