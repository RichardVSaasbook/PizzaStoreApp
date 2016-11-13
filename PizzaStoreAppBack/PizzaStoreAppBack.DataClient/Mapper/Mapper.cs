using PizzaStoreAppBack.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Mapper {
    /// <summary>
    /// Maps EF entities to Data Access Objects and vice-versa.
    /// </summary>
    public partial class Mapper {
        private PizzaStoreAppData data;

        /// <summary>
        /// Create a new data Mapper.
        /// </summary>
        /// <param name="data">The PizzaStoreAppData for access EF entities.</param>
        public Mapper(PizzaStoreAppData data) {
            this.data = data;
        }
    }
}