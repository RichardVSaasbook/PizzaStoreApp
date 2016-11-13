using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    public partial class Mapper {
        /// <summary>
        /// Map an Person to PersonDAO.
        /// </summary>
        /// <param name="person">The Person to map from.</param>
        /// <returns>The mapped PersonDAO.</returns>
        public PersonDAO MapToPersonDAO(Person person) {
            return new PersonDAO {
                Address = MapToAddressDAO(person.Address),
                CreatedDate = person.CreatedDate,
                FirstName = person.FirstName,
                LastName = person.LastName,
                PersonId = person.PersonId,
                Phone = MapToPhoneDAO(person.Phone),
                UpdatedDate = person.UpdatedDate
            };
        }

        /// <summary>
        /// Map an PersonDAO to Person.
        /// </summary>
        /// <param name="personDAO">The PersonDAO to map from.</param>
        /// <returns>The mapped Person.</returns>
        public Person MapToPerson(PersonDAO personDAO) {
            Person person = data.FindPerson(personDAO.PersonId);
            Address address = MapToAddress(personDAO.Address);
            Phone phone = MapToPhone(personDAO.Phone);

            person.Address = address;
            person.AddressId = address.AddressId;
            person.CreatedDate = personDAO.CreatedDate;
            person.FirstName = personDAO.FirstName;
            person.LastName = personDAO.LastName;
            person.PersonId = personDAO.PersonId;
            person.Phone = phone;
            person.PhoneId = phone.PhoneId;
            person.UpdatedDate = personDAO.UpdatedDate;

            return person;
        }
    }
}