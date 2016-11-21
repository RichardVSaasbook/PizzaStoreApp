using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppBack.DataAccess {
    public partial class PizzaStoreAppData {
        /// <summary>
        /// Add a Store to our application.
        /// </summary>
        /// <param name="store">The Store to add.</param>
        /// <returns>True if the addition was successful.</returns>
        public bool AddStore(Store store, Person owner, Address address, Phone phone) {
            owner.Address = address;
            owner.AddressId = address.AddressId;
            owner.Phone = phone;
            owner.PhoneId = phone.PhoneId;

            store.Address = address;
            store.AddressId = address.AddressId;
            store.Phone = phone;
            store.PhoneId = phone.PhoneId;
            store.Person = owner;
            store.OwnerId = owner.PersonId;

            db.Stores.Add(store);
            return db.SaveChanges() > 0;
        }

        /// <summary>
        /// Remove a Store from the application.
        /// </summary>
        /// <param name="store">The Store to remove.</param>
        /// <returns>True if the removal was succesful.</returns>
        public bool RemoveStore(Store store) {
            db.Stores.Remove(store);
            return db.SaveChanges() > 0;
        }

        /// <summary>
        /// Updates the information for a Store.
        /// </summary>
        /// <param name="store">The Store to update.</param>
        /// <returns>True if the update was successful.</returns>
        public bool UpdateStore(Store store) {
            var entry = db.Entry(store);
            entry.State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() > 0;
        }

        /// <summary>
        /// List all of the Orders from a given Store.
        /// </summary>
        /// <param name="storeId">The Id for the Store to List Orders from.</param>
        /// <returns>The List of Orders.</returns>
        public List<Order> ListStoreOrders(int storeId) {
            return db.Orders.Where(p => p.StoreId == storeId).OrderByDescending(p => p.CreatedDate).ToList();
        }

        /// <summary>
        /// Find the closest Store to an Address.
        /// </summary>
        /// <param name="address">The Address to search with</param>
        /// <returns>The closest Store.</returns>
        public Store FindClosestStore(Address address) {
            Store store = FindStore(1);

            // Todo, actual calculation.

            return store;
        }

        public List<Store> ListStores() {
            return db.Stores.Where(s => s.Active).ToList();
        }

        public List<Person> ListPeople() {
            return db.People.Where(p => p.Active).ToList();
        }
    }
}
