using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppBack.DataAccess {
    /// <summary>
    /// A container for a Pizza and its Price.
    /// </summary>
    public class PizzaData {
        public Pizza Pizza { get; set; }
        public decimal Price { get; set; }
    }
}
