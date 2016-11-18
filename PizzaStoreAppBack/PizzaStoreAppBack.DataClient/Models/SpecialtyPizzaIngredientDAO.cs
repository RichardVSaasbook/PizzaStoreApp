using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Models {
    [DataContract]
    public class SpecialtyPizzaIngredientDAO {
        [DataMember]
        public IngredientDAO Ingredient { get; set; }

        [DataMember]
        public SpecialtyPizzaDAO SpecialtyPizza { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public DateTime UpdatedDate { get; set; }
    }
}