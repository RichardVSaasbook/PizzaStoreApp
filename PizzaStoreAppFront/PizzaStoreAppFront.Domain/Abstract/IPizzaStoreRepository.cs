using PizzaStoreAppFront.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppFront.Domain.Abstract {
    public interface IPizzaStoreRepository {
        IEnumerable<Ingredient> ListIngredients(string type);
        Ingredient GetIngredient(int ingredientId);
        IEnumerable<Size> ListSizes();
        Size GetSize(int sizeId);
    }
}
