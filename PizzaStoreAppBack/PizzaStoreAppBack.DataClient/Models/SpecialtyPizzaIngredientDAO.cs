using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Models {
    public class SpecialtyPizzaIngredientDAO {
        public IngredientDAO Ingredient { get; set; }
        public SpecialtyPizzaDAO SpecialtyPizza { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}