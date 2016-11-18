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
        public bool CreateOrder(int customerId, List<PizzaDAO> pizzasDAOs) {
            List<Pizza> pizzas = new List<Pizza>();

            foreach (PizzaDAO pizzaDAO in pizzasDAOs) {
                pizzas.Add(mapper.MapToPizza(pizzaDAO));
            }

            return data.SubmitOrder(data.FindPerson(customerId), pizzas);
        }
    }
}
