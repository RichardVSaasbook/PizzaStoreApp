using PizzaStoreAppFront.Domain.Abstract;
using PizzaStoreAppFront.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppFront.Client.Infrastructure {
    public static class CustomerSetup {
        public static void SetupCustomersIfNeeded(IPizzaStoreRepository repository, HttpSessionStateBase session) {
            if (session["Customers"] == null) {
                List<Person> people = repository.ListPeople();
                Dictionary<int, Store> nearestStores = new Dictionary<int, Store>();

                //foreach (Person person in people) {
                //    nearestStores[person.PersonId] = repository.GetNearestStore(person.Address);
                //}

                // Mock nearest store; to be removed when published!
                List<Store> stores = repository.ListStores();
                nearestStores = new Dictionary<int, Store> {
                    { 1, stores[0] },
                    { 2, stores[1] },
                    { 3, stores[2] },
                    { 4, stores[3] },
                    { 5, stores[4] },
                    { 6, stores[1] },
                    { 7, stores[0] }
                };

                session["Customers"] = people;
                session["CustomerNearestStores"] = nearestStores;
            }
        }
    }
}