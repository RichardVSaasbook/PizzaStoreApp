using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppFront.Domain.Models {
    public class OrderData {
        public int storeId { get; set; }
        public int customerId { get; set; }
        public List<Pizza> pizzas { get; set; }
        public decimal subTotal { get; set; }
        public decimal taxTotal { get; set; }
        public decimal total { get; set; }
    }
}
