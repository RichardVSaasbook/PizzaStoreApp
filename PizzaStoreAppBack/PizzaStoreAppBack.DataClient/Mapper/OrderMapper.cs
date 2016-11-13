using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    public partial class Mapper {
        /// <summary>
        /// Map an Order to OrderDAO.
        /// </summary>
        /// <param name="order">The Order to map from.</param>
        /// <returns>The mapped OrderDAO.</returns>
        public OrderDAO MapToOrderDAO(Order order) {
            return new OrderDAO {
                CreatedDate = order.CreatedDate,
                Customer = MapToPersonDAO(order.Person),
                OrderId = order.OrderId,
                Store = MapToStoreDAO(order.Store),
                SubTotal = order.SubTotal,
                Tax = order.Tax,
                Total = order.Total,
                UpdatedDate = order.UpdatedDate
            };
        }

        /// <summary>
        /// Map an OrderDAO to Order.
        /// </summary>
        /// <param name="orderDAO">The OrderDAO to map from.</param>
        /// <returns>The mapped Order.</returns>
        public Order MapToOrder(OrderDAO orderDAO) {
            Order order = data.FindOrder(orderDAO.OrderId);
            Person customer = MapToPerson(orderDAO.Customer);
            Store store = MapToStore(orderDAO.Store);

            order.CreatedDate = orderDAO.CreatedDate;
            order.CustomerId = customer.PersonId;
            order.OrderId = orderDAO.OrderId;
            order.Person = customer;
            order.Store = store;
            order.StoreId = store.StoreId;
            order.SubTotal = orderDAO.SubTotal;
            order.Tax = orderDAO.Tax;
            order.Total = orderDAO.Total;
            order.UpdatedDate = orderDAO.UpdatedDate;

            return order;
        }
    }
}