using PizzaStoreAppFront.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppFront.Client.Models {
    public class PizzaViewModel {
        public decimal Price { get; set; }
        public string Name { get; set; }
        public Size Size { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}