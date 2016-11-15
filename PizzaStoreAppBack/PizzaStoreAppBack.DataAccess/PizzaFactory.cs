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
        public static PizzaData BuildPizza(List<Ingredient> ingredients, Size size, SpecialtyPizza specialtyPizza = null) {
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

            if (specialtyPizza != null) {
                pizza.SpecialtyPizza = specialtyPizza;
                pizza.SpecialtyPizzaId = specialtyPizza.SpecialtyPizzaId;
            }

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
