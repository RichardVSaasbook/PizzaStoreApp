using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Models {
    public class StoreDAO {
        public int StoreId { get; set; }
        public OwnerDAO Owner { get; set; }
        public PhoneDAO Phone { get; set; }
        public AddressDAO Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}