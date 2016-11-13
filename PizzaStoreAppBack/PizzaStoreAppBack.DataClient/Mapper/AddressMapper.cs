using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    public partial class Mapper {
        /// <summary>
        /// Map an Address to AddressDAO.
        /// </summary>
        /// <param name="address">The Address to map from.</param>
        /// <returns>The mapped AddressDAO.</returns>
        public AddressDAO MapToAddressDAO(Address address) {
            return new AddressDAO {
                AddressId = address.AddressId,
                City = address.City,
                CreatedDate = address.CreatedDate,
                State = address.State,
                Street = address.Street,
                UpdatedDate = address.UpdatedDate,
                Zip = address.Zip
            };
        }

        /// <summary>
        /// Map an AddressDAO to Address.
        /// </summary>
        /// <param name="addressDAO">The AddressDAO to map from.</param>
        /// <returns>The mapped Address.</returns>
        public Address MapToAddress(AddressDAO addressDAO) {
            Address address = data.FindAddress(addressDAO.AddressId);

            address.AddressId = addressDAO.AddressId;
            address.City = addressDAO.City;
            address.CreatedDate = addressDAO.CreatedDate;
            address.State = addressDAO.State;
            address.Street = addressDAO.Street;
            address.UpdatedDate = addressDAO.UpdatedDate;
            address.Zip = addressDAO.Zip;

            return address;
        }
    }
}