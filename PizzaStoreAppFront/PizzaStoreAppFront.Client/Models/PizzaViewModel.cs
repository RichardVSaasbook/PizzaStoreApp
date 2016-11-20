using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppFront.Client.Models {
    public class PizzaViewModel {
        public string Price { get; set; }
        public string Name { get; set; }
        public string Crust { get; set; }
        public string Sauce { get; set; }
        public string Cheese { get; set; }
        public List<string> Toppings { get; set; }
        public List<string> Ingredients { get; set; }
    }
}