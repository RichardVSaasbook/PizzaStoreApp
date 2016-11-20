using PizzaStoreAppBack.DataAccess;
using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PizzaStoreAppBack.DataClient {
    public class SizeService : ISizeService {
        private PizzaStoreAppData data;
        private Mapper.Mapper mapper;

        public SizeService() {
            data = new PizzaStoreAppData();
            mapper = new Mapper.Mapper(data);
        }

        /// <summary>
        /// Gets a single Size.
        /// </summary>
        /// <param name="sizeId">The Size to get.</param>
        /// <returns>The Size which will contain no data if not found.</returns>
        public SizeDAO GetSize(int sizeId) {
            return mapper.MapToSizeDAO(data.FindSize(sizeId));
        }

        /// <summary>
        /// List the Pizza Sizes.
        /// </summary>
        /// <returns>The List of Sizes.</returns>
        public List<SizeDAO> ListSizes() {
            List<SizeDAO> sizes = new List<SizeDAO>();

            foreach (Size size in data.ListSizes()) {
                sizes.Add(mapper.MapToSizeDAO(size));
            }

            return sizes;
        }
    }
}
