using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Models {
    [DataContract]
    public class StoreDAO {
        [DataMember]
        public int StoreId { get; set; }

        [DataMember]
        public PersonDAO Owner { get; set; }

        [DataMember]
        public PhoneDAO Phone { get; set; }

        [DataMember]
        public AddressDAO Address { get; set; }

        [DataMember]
        public decimal SalesTax { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public DateTime UpdatedDate { get; set; }
    }
}