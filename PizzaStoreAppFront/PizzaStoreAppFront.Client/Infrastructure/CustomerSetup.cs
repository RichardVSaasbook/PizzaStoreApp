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

                foreach (Person person in people) {
                    nearestStores[person.PersonId] = repository.GetNearestStore(person.Address);
                }

                session["Customers"] = people;
                session["CustomerNearestStores"] = nearestStores;
            }
        }
    }
}