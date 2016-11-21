using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PizzaStoreAppBack.DataClient.Models;
using PizzaStoreAppBack.DataAccess;

namespace PizzaStoreAppBack.DataClient {
    public class PizzaService : IPizzaService {
        private PizzaStoreAppData data;
        private Mapper.Mapper mapper;

        public PizzaService() {
            data = new PizzaStoreAppData();
            mapper = new Mapper.Mapper(data);
        }

        /// <summary>
        /// Create an Order in the closest Store to the customer.
        /// </summary>
        /// <param name="customerId">The Id of the customer Person.</param>
        /// <param name="pizzasDAOs">The List of Pizzas in the Order.</param>
        /// <returns>True if the Order was created successfully.</returns>
        public bool CreateOrder(int storeId, int customerId, List<PizzaDAO> pizzasDAOs, decimal subTotal, decimal taxTotal, decimal total) {
            List<Pizza> pizzas = new List<Pizza>();

            foreach (PizzaDAO pizzaDAO in pizzasDAOs) {
                pizzas.Add(mapper.MapToPizza(pizzaDAO));
            }

            return data.SubmitOrder(data.FindStore(storeId), data.FindPerson(customerId), pizzas, subTotal, taxTotal, total);
        }

        public List<PizzaDAO> ListPizzasInOrder(int orderId) {
            List<PizzaDAO> pizzaDAOs = new List<PizzaDAO>();

            foreach (Pizza pizza in data.ListPizzasInOrder(orderId)) {
                pizzaDAOs.Add(mapper.MapToPizzaDAO(pizza));
            }

            return pizzaDAOs;
        }
    }
}
