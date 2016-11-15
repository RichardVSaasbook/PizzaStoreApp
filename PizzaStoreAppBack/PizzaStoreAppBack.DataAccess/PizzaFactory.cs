using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppBack.DataAccess {
    /// <summary>
    /// Factory for creating Pizzas.
    /// </summary>
    public static class PizzaFactory {
        /// <summary>
        /// Build a Pizza.
        /// </summary>
        /// <param name="ingredients">The List of Ingredients on the Pizza.</param>
        /// <param name="size">The Size of the Pizza.</param>
        /// <returns>The built Pizza and its price.</returns>
        public static PizzaData BuildPizza(List<Ingredient> ingredients, Size size) {
            bool hasCrust = false,
                hasSauce = false,
                hasCheese = false;
            decimal price = size.Price;

            Pizza pizza = new Pizza {
                CreatedDate = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow,
                Active = true,
                Size = size
            };

            foreach (Ingredient ingredient in ingredients) {
                if (ingredient.Type == "Crust") {
                    if (hasCrust) {
                        return null;
                    }
                    
                    hasCrust = true;
                }
                else if (ingredient.Type == "Sauce") {
                    if (hasSauce) {
                        return null;
                    }

                    hasSauce = true;
                }
                else if (ingredient.Type == "Cheese") {
                    if (hasCheese) {
                        return null;
                    }

                    hasCheese = true;
                }

                pizza.PizzaIngredients.Add(new PizzaIngredient {
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    Active = true,
                    Ingredient = ingredient,
                    IngredientId = ingredient.IngredientId
                });

                price += ingredient.Price;
            }

            return new PizzaData {
                Pizza = pizza,
                Price = price
            };
        }
    }
}
