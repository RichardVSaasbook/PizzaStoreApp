using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    public partial class Mapper {
        /// <summary>
        /// Map an Store to StoreDAO.
        /// </summary>
        /// <param name="store">The Store to map from.</param>
        /// <returns>The mapped StoreDAO.</returns>
        public StoreDAO MapToStoreDAO(Store store) {
            return new StoreDAO {
                Address = MapToAddressDAO(store.Address),
                CreatedDate = store.CreatedDate,
                Owner = MapToPersonDAO(store.Person),
                Phone = MapToPhoneDAO(store.Phone),
                SalesTax = store.SalesTax,
                StoreId = store.StoreId,
                UpdatedDate = store.UpdatedDate
            };
        }

        /// <summary>
        /// Map an StoreDAO to Store.
        /// </summary>
        /// <param name="storeDAO">The StoreDAO to map from.</param>
        /// <returns>The mapped Store.</returns>
        public Store MapToStore(StoreDAO storeDAO) {
            Store store = data.FindStore(storeDAO.StoreId);
            Address address = MapToAddress(storeDAO.Address);
            Person owner = MapToPerson(storeDAO.Owner);
            Phone phone = MapToPhone(storeDAO.Phone);

            store.Address = address;
            store.AddressId = address.AddressId;
            store.CreatedDate = storeDAO.CreatedDate;
            store.OwnerId = owner.PersonId;
            store.Person = owner;
            store.Phone = phone;
            store.PhoneId = phone.PhoneId;
            store.SalesTax = storeDAO.SalesTax;
            store.StoreId = storeDAO.StoreId;
            store.UpdatedDate = storeDAO.UpdatedDate;

            return store;
        }
    }
}