using PizzaStoreAppFront.Domain.Concrete;
using PizzaStoreAppFront.Domain.PizzaDataServiceReference;
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
        public Person Customer { get; set; }

        public static Order FromDAO(OrderDAO orderDAO) {
            PizzaStoreRepository repository = new PizzaStoreRepository();
            
            return new Order {
                Customer = Person.FromDAO(orderDAO.Customer),
                OrderId = orderDAO.OrderId,
                OrderDate = orderDAO.CreatedDate,
                Pizzas = repository.ListPizzasInOrder(orderDAO.OrderId),
                SubTotal = orderDAO.SubTotal,
                TaxTotal = orderDAO.Tax,
                Total = orderDAO.Total
            };
        }
    }
}
