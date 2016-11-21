using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Models {
    [DataContract]
    public class PizzaDAO {
        [DataMember]
        public int PizzaId { get; set; }

        [DataMember]
        public SizeDAO Size { get; set; }

        [DataMember]
        public List<IngredientDAO> Ingredients { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public DateTime UpdatedDate { get; set; }
    }
}