using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppFront.Client.Models {
    public class OrderViewModel {
        public int CustomerId { get; set; }
        public OrderIngredientsViewModel Ingredients { get; set; }
        public OrderDetailsViewModel OrderDetails { get; set; }
    }
}