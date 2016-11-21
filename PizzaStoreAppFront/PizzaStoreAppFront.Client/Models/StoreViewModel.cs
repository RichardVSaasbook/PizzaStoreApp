using PizzaStoreAppFront.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppFront.Client.Models {
    public class StoreViewModel {
        public List<Store> Stores { get; set; }
        public int CurrentStoreId { get; set; }
    }
}