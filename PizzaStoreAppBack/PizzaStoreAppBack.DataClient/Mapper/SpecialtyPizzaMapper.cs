using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    public partial class Mapper {
        /// <summary>
        /// Map an SpecialtyPizza to SpecialtyPizzaDAO.
        /// </summary>
        /// <param name="specialtyPizza">The SpecialtyPizza to map from.</param>
        /// <returns>The mapped SpecialtyPizzaDAO.</returns>
        public SpecialtyPizzaDAO MapToSpecialtyPizzaDAO(SpecialtyPizza specialtyPizza) {
            return new SpecialtyPizzaDAO {
                CreatedDate = specialtyPizza.CreatedDate,
                Name = specialtyPizza.Name,
                SpecialtyPizzaId = specialtyPizza.SpecialtyPizzaId,
                UpdatedDate = specialtyPizza.UpdatedDate
            };
        }

        /// <summary>
        /// Map an SpecialtyPizzaDAO to SpecialtyPizza.
        /// </summary>
        /// <param name="specialtyPizzaDAO">The SpecialtyPizzaDAO to map from.</param>
        /// <returns>The mapped SpecialtyPizza.</returns>
        public SpecialtyPizza MapToSpecialtyPizza(SpecialtyPizzaDAO specialtyPizzaDAO) {
            SpecialtyPizza specialtyPizza = data.FindSpecialtyPizza(specialtyPizzaDAO.SpecialtyPizzaId);

            specialtyPizza.CreatedDate = specialtyPizzaDAO.CreatedDate;
            specialtyPizza.Name = specialtyPizzaDAO.Name;
            specialtyPizza.SpecialtyPizzaId = specialtyPizzaDAO.SpecialtyPizzaId;
            specialtyPizza.UpdatedDate = specialtyPizzaDAO.UpdatedDate;

            return specialtyPizza;
        }
    }
}