using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    public partial class Mapper {
        /// <summary>
        /// Map an PizzaOrder to PizzaOrderDAO.
        /// </summary>
        /// <param name="pizzaOrder">The PizzaOrder to map from.</param>
        /// <returns>The mapped PizzaOrderDAO.</returns>
        public PizzaOrderDAO MapToPizzaOrderDAO(PizzaOrder pizzaOrder) {
            return new PizzaOrderDAO {
                CreatedDate = pizzaOrder.CreatedDate,
                Order = MapToOrderDAO(pizzaOrder.Order),
                Pizza = MapToPizzaDAO(pizzaOrder.Pizza),
                UpdatedDate = pizzaOrder.UpdatedDate
            };
        }

        /// <summary>
        /// Map an PizzaOrderDAO to PizzaOrder.
        /// </summary>
        /// <param name="pizzaOrderDAO">The PizzaOrderDAO to map from.</param>
        /// <returns>The mapped PizzaOrder.</returns>
        public PizzaOrder MapToPizzaOrder(PizzaOrderDAO pizzaOrderDAO) {
            PizzaOrder pizzaOrder = data.FindPizzaOrder(pizzaOrderDAO.Pizza.PizzaId, pizzaOrderDAO.Order.OrderId);
            Order order = MapToOrder(pizzaOrderDAO.Order);
            Pizza pizza = MapToPizza(pizzaOrderDAO.Pizza);

            pizzaOrder.CreatedDate = pizzaOrderDAO.CreatedDate;
            pizzaOrder.Order = order;
            pizzaOrder.OrderId = order.OrderId;
            pizzaOrder.Pizza = pizza;
            pizzaOrder.PizzaId = pizza.PizzaId;
            pizzaOrder.UpdatedDate = pizzaOrderDAO.UpdatedDate;

            return pizzaOrder;
        }
    }
}