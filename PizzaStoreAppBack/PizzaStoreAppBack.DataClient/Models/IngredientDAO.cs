using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreAppBack.DataClient.Models {
    public class IngredientDAO {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}