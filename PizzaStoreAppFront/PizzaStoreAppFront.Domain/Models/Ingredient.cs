using PizzaStoreAppFront.Domain.IngredientServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppFront.Domain.Models {
    public class Ingredient {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public static Ingredient FromDAO(IngredientDAO ingredientDAO) {
            return new Ingredient {
                IngredientId = ingredientDAO.IngredientId,
                Name = ingredientDAO.Name,
                Price = ingredientDAO.Price
            };
        }
    }
}
