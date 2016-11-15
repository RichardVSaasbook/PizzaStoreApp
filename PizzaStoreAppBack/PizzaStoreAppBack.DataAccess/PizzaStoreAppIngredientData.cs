using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppBack.DataAccess
{
    public partial class PizzaStoreAppData
    {
        /// <summary>
        /// Lists all of the crusts customers can choose from.
        /// </summary>
        /// <returns>The List of crusts.</returns>
        public List<Ingredient> ListCrusts()
        {
            return ListIngredients("Crust");
        }

        /// <summary>
        /// Lists all of the sauces customers can choose from.
        /// </summary>
        /// <returns>The List of sauces.</returns>
        public List<Ingredient> ListSauces()
        {
            return ListIngredients("Sauce");
        }

        /// <summary>
        /// Lists all of the cheeses customers can choose from.
        /// </summary>
        /// <returns>The List of cheeses.</returns>
        public List<Ingredient> ListCheeses()
        {
            return ListIngredients("Cheese");
        }

        /// <summary>
        /// Lists all of the toppings customers can choose from.
        /// </summary>
        /// <returns>The List of toppings.</returns>
        public List<Ingredient> ListToppings()
        {
            return ListIngredients("Topping");
        }

        /// <summary>
        /// List Ingredients of a specific type.
        /// </summary>
        /// <param name="type">The type to list.</param>
        /// <returns>The List of Ingredients.</returns>
        public List<Ingredient> ListIngredients(string type)
        {
            return db.Ingredients.Where(i => i.Type == type && i.Active).OrderBy(i => i.Name).ToList();
        }

        /// <summary>
        /// Adds an Ingredient.
        /// </summary>
        /// <param name="ingredient">The Ingredient to add.</param>
        /// <returns>True if the addition was successful.</returns>
        public bool AddIngredient(Ingredient ingredient)
        {
            ingredient.CreatedDate = DateTime.UtcNow;
            ingredient.UpdatedDate = DateTime.UtcNow;
            ingredient.Active = true;

            db.Ingredients.Add(ingredient);
            return db.SaveChanges() > 0;
        }

        /// <summary>
        /// Remove an Ingredient.
        /// </summary>
        /// <param name="ingredient">The Ingredient to remove.</param>
        /// <returns>True if the removal was successful.</returns>
        public bool RemoveIngredient(Ingredient ingredient)
        {
            db.Ingredients.Remove(ingredient);
            return db.SaveChanges() > 0;
        }

        /// <summary>
        /// Update an Ingredient.
        /// </summary>
        /// <param name="ingredient">The Ingredient to update.</param>
        /// <returns>True if the update was successful.</returns>
        public bool UpdateIngredient(Ingredient ingredient)
        {
            var entry = db.Entry(ingredient);
            entry.State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}
