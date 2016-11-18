using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Models {
    [DataContract]
    public class SizeDAO {
        [DataMember]
        public int SizeId { get; set; }

        [DataMember]
        public int Dimension { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public DateTime UpdatedDate { get; set; }
    }
}