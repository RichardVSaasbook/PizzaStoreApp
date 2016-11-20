﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppFront.Domain.Models {
    public class Pizza {
        public List<Ingredient> Ingredients { get; set; }
        public Size Size { get; set; }
        public Decimal Price { get; set; }
    }
}
