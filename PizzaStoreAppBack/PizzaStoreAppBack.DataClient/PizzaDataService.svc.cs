using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PizzaStoreAppBack.DataClient.Models;
using PizzaStoreAppBack.DataAccess;

namespace PizzaStoreAppBack.DataClient {
    public class PizzaDataService : IPizzaDataService {
        private PizzaStoreAppData data;
        private Mapper.Mapper mapper;

        public PizzaDataService() {
            data = new PizzaStoreAppData();
            mapper = new Mapper.Mapper(data);
        }

        public AddressDAO GetAddress(int addressId) {
            return mapper.MapToAddressDAO(data.FindAddress(addressId));
        }

        public PersonDAO GetPerson(int personId) {
            return mapper.MapToPersonDAO(data.FindPerson(personId));
        }

        public PhoneDAO GetPhone(int phoneId) {
            return mapper.MapToPhoneDAO(data.FindPhone(phoneId));
        }

        public StoreDAO GetStore(int storeId) {
            return mapper.MapToStoreDAO(data.FindStore(storeId));
        }

        public List<OrderDAO> ListStoreOrders(int storeId) {
            List<OrderDAO> orderDAOs = new List<OrderDAO>();

            foreach (Order order in data.ListStoreOrders(storeId)) {
                orderDAOs.Add(mapper.MapToOrderDAO(order));
            }

            return orderDAOs;
        }

        public List<StoreDAO> ListStores() {
            List<StoreDAO> storeDAOs = new List<StoreDAO>();

            foreach (Store store in data.ListStores()) {
                storeDAOs.Add(mapper.MapToStoreDAO(store));
            }

            return storeDAOs;
        }

        public List<PersonDAO> ListPeople() {
            List<PersonDAO> personDAOs = new List<PersonDAO>();

            foreach (Person person in data.ListPeople()) {
                personDAOs.Add(mapper.MapToPersonDAO(person));
            }

            return personDAOs;
        }

        /// <summary>
        /// List the cheese Ingredients available.
        /// </summary>
        /// <returns>The List of cheeses.</returns>
        public List<IngredientDAO> ListCheeses() {
            List<IngredientDAO> cheeses = new List<IngredientDAO>();

            foreach (Ingredient cheese in data.ListCheeses()) {
                cheeses.Add(mapper.MapToIngredientDAO(cheese));
            }

            return cheeses;
        }

        /// <summary>
        /// List the crust Ingredients available.
        /// </summary>
        /// <returns>The List of crusts.</returns>
        public List<IngredientDAO> ListCrusts() {
            List<IngredientDAO> crusts = new List<IngredientDAO>();

            foreach (Ingredient crust in data.ListCrusts()) {
                crusts.Add(mapper.MapToIngredientDAO(crust));
            }

            return crusts;
        }

        /// <summary>
        /// List the sauce Ingredients available.
        /// </summary>
        /// <returns>The List of sauces.</returns>
        public List<IngredientDAO> ListSauces() {
            List<IngredientDAO> sauaces = new List<IngredientDAO>();

            foreach (Ingredient sauce in data.ListSauces()) {
                sauaces.Add(mapper.MapToIngredientDAO(sauce));
            }

            return sauaces;
        }

        /// <summary>
        /// List the topping Ingredients available.
        /// </summary>
        /// <returns>The List of toppings.</returns>
        public List<IngredientDAO> ListToppings() {
            List<IngredientDAO> toppings = new List<IngredientDAO>();

            foreach (Ingredient topping in data.ListToppings()) {
                toppings.Add(mapper.MapToIngredientDAO(topping));
            }

            return toppings;
        }

        /// <summary>
        /// Gets a single Ingredient.
        /// </summary>
        /// <param name="ingredientId">The Ingredient to get.</param>
        /// <returns>The Ingredient which will contain no data if not found.</returns>
        public IngredientDAO GetIngredient(int ingredientId) {
            return mapper.MapToIngredientDAO(data.FindIngredient(ingredientId));
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
                pizzaDAO.Size = mapper.MapToSizeDAO(data.FindSize(pizzaDAO.Size.SizeId));

                List<IngredientDAO> ingredientDAOs = new List<IngredientDAO>();
                foreach (IngredientDAO ingredientDAO in pizzaDAO.Ingredients) {
                    ingredientDAOs.Add(mapper.MapToIngredientDAO(data.FindIngredient(ingredientDAO.IngredientId)));
                }

                pizzaDAO.Ingredients = ingredientDAOs;
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

        /// <summary>
        /// Gets a single Size.
        /// </summary>
        /// <param name="sizeId">The Size to get.</param>
        /// <returns>The Size which will contain no data if not found.</returns>
        public SizeDAO GetSize(int sizeId) {
            return mapper.MapToSizeDAO(data.FindSize(sizeId));
        }

        /// <summary>
        /// List the Pizza Sizes.
        /// </summary>
        /// <returns>The List of Sizes.</returns>
        public List<SizeDAO> ListSizes() {
            List<SizeDAO> sizes = new List<SizeDAO>();

            foreach (Size size in data.ListSizes()) {
                sizes.Add(mapper.MapToSizeDAO(size));
            }

            return sizes;
        }
    }
}
