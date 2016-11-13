using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    public partial class Mapper {
        /// <summary>
        /// Map an Size to SizeDAO.
        /// </summary>
        /// <param name="size">The Size to map from.</param>
        /// <returns>The mapped SizeDAO.</returns>
        public SizeDAO MapToSizeDAO(Size size) {
            return new SizeDAO {
                CreatedDate = size.CreatedDate,
                Dimension = size.Dimension,
                Price = size.Price,
                SizeId = size.SizeId,
                UpdatedDate = size.UpdatedDate
            };
        }

        /// <summary>
        /// Map an SizeDAO to Size.
        /// </summary>
        /// <param name="sizeDAO">The SizeDAO to map from.</param>
        /// <returns>The mapped Size.</returns>
        public Size MapToSize(SizeDAO sizeDAO) {
            Size size = data.FindSize(sizeDAO.SizeId);

            size.CreatedDate = sizeDAO.CreatedDate;
            size.Dimension = sizeDAO.Dimension;
            size.Price = sizeDAO.Price;
            size.SizeId = sizeDAO.SizeId;
            size.UpdatedDate = sizeDAO.UpdatedDate;

            return size;
        }
    }
}