using PizzaStoreAppFront.Domain.PizzaDataServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppFront.Domain.Models {
    public class Store {
        public int StoreId { get; set; }
        public decimal SalesTax { get; set; }
        public Person Owner { get; set; }
        public Phone Phone { get; set; }
        public Address Address { get; set; }

        public static Store FromDAO(StoreDAO storeDAO) {
            return new Store {
                StoreId = storeDAO.StoreId,
                SalesTax = storeDAO.SalesTax,
                Owner = Person.FromDAO(storeDAO.Owner),
                Phone = Phone.FromDAO(storeDAO.Phone),
                Address = Address.FromDAO(storeDAO.Address)
            };
        }
    }
}
