using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    public partial class Mapper {
        /// <summary>
        /// Map an Phone to PhoneDAO.
        /// </summary>
        /// <param name="phone">The Phone to map from.</param>
        /// <returns>The mapped PhoneDAO.</returns>
        public PhoneDAO MapToPhoneDAO(Phone phone) {
            if (phone == null) {
                return new PhoneDAO();
            }

            return new PhoneDAO {
                CreatedDate = phone.CreatedDate,
                Number = phone.Number,
                PhoneId = phone.PhoneId,
                UpdatedDate = phone.UpdatedDate
            };
        }

        /// <summary>
        /// Map an PhoneDAO to Phone.
        /// </summary>
        /// <param name="phoneDAO">The PhoneDAO to map from.</param>
        /// <returns>The mapped Phone.</returns>
        public Phone MapToPhone(PhoneDAO phoneDAO) {
            Phone phone = data.FindPhone(phoneDAO.PhoneId);

            phone.CreatedDate = phoneDAO.CreatedDate;
            phone.Number = phoneDAO.Number;
            phone.PhoneId = phoneDAO.PhoneId;
            phone.UpdatedDate = phoneDAO.UpdatedDate;

            return phone;
        }
    }
}