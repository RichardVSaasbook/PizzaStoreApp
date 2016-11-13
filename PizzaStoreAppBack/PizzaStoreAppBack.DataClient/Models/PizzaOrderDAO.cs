using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Models {
    public class PizzaOrderDAO {
        public PizzaDAO Pizza { get; set; }
        public OrderDAO Order { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}