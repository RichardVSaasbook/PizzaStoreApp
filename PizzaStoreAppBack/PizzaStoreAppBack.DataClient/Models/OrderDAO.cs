using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Models {
    [DataContract]
    public class OrderDAO {
        [DataMember]
        public int OrderId { get; set; }

        [DataMember]
        public decimal SubTotal { get; set; }

        [DataMember]
        public decimal Tax { get; set; }

        [DataMember]
        public decimal Total { get; set; }

        [DataMember]
        public StoreDAO Store { get; set; }

        [DataMember]
        public PersonDAO Customer { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public DateTime UpdatedDate { get; set; }
    }
}