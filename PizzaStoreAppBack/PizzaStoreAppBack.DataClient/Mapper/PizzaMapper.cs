using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    public partial class Mapper {
        /// <summary>
        /// Map an Pizza to PizzaDAO.
        /// </summary>
        /// <param name="pizza">The Pizza to map from.</param>
        /// <returns>The mapped PizzaDAO.</returns>
        public PizzaDAO MapToPizzaDAO(Pizza pizza) {
            return new PizzaDAO {
                CreatedDate = pizza.CreatedDate,
                PizzaId = pizza.PizzaId,
                Size = MapToSizeDAO(pizza.Size),
                UpdatedDate = pizza.UpdatedDate
            };
        }

        /// <summary>
        /// Map an PizzaDAO to Pizza.
        /// </summary>
        /// <param name="pizzaDAO">The PizzaDAO to map from.</param>
        /// <returns>The mapped Pizza.</returns>
        public Pizza MapToPizza(PizzaDAO pizzaDAO) {
            Pizza pizza = data.FindPizza(pizzaDAO.PizzaId);
            Size size = MapToSize(pizzaDAO.Size);

            pizza.CreatedDate = pizzaDAO.CreatedDate;
            pizza.PizzaId = pizzaDAO.PizzaId;
            pizza.Size = size;
            pizza.SizeId = size.SizeId;
            pizza.UpdatedDate = pizzaDAO.UpdatedDate;

            return pizza;
        }
    }
}