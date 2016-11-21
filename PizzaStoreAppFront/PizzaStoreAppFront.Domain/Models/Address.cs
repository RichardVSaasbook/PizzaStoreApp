using PizzaStoreAppFront.Domain.PizzaDataServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppFront.Domain.Models {
    public class Address {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public string ToString() {
            return Street + ", " + City + ", " + State + " " + Zip;
        }

        public static Address FromDAO(AddressDAO addressDAO) {
            return new Address {
                City = addressDAO.City,
                State = addressDAO.State,
                Street = addressDAO.Street,
                Zip = addressDAO.Zip
            };
        }
    }
}
