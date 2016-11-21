using PizzaStoreAppFront.Domain.PizzaDataServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppFront.Domain.Models {
    public class Person {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Phone Phone { get; set; }
        public Address Address { get; set; }

        public static Person FromDAO(PersonDAO personDAO) {
            return new Person {
                PersonId = personDAO.PersonId,
                Address = Address.FromDAO(personDAO.Address),
                FirstName = personDAO.FirstName,
                LastName = personDAO.LastName,
                Phone = Phone.FromDAO(personDAO.Phone)
            };
        }
    }
}
