using PizzaStoreAppFront.Domain.PizzaDataServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppFront.Domain.Models {
    public class Phone {
        public string Number { get; set; }

        public static Phone FromDAO(PhoneDAO phoneDAO) {
            return new Phone {
                Number = phoneDAO.Number
            };
        }
    }
}
