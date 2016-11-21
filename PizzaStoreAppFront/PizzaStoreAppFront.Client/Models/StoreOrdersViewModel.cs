using PizzaStoreAppFront.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppFront.Client.Models {
    public class StoreOrdersViewModel {
        public StoreViewModel StoreViewModel { get; set; }
        public List<Order> Orders { get; set; }
    }
}