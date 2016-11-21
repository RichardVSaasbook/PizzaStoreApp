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
    }
}
