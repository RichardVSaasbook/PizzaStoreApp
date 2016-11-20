using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppFront.Client.Models {
    public class OrderDetailsViewModel {
        public List<PizzaViewModel> Pizzas { get; set; }
        public string SubTotal { get; set; }
        public string TaxTotal { get; set; }
        public string Total { get; set; }
    }
}