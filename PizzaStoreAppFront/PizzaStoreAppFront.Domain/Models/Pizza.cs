using PizzaStoreAppFront.Domain.PizzaDataServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppFront.Domain.Models {
    public class Pizza {
        public List<Ingredient> Ingredients { get; set; }
        public Size Size { get; set; }
        public decimal Price { get; set; }

        public static Pizza FromDAO(PizzaDAO pizzaDAO) {
            List<Ingredient> ingredients = new List<Ingredient>();

            foreach (IngredientDAO ingredientDAO in pizzaDAO.Ingredients) {
                ingredients.Add(Ingredient.FromDAO(ingredientDAO));
            }

            return new Pizza {
                Ingredients = ingredients,
                Size = Size.FromDAO(pizzaDAO.Size)
            };
        }
    }
}
