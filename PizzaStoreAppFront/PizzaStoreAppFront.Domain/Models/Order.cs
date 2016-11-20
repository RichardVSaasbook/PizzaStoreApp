using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppFront.Domain.Models {
    public class Order {
        public int OrderId { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
