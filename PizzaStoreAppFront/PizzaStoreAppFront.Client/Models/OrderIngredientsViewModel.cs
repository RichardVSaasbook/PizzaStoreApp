using PizzaStoreAppFront.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreAppFront.Client.Models {
    /// <summary>
    /// ViewModel which contains all of the Ingredients to display on the form.
    /// </summary>
    public class OrderIngredientsViewModel {
        public IEnumerable<SelectListItem> Sizes { get; set; }
        public IEnumerable<SelectListItem> Cheeses { get; set; }
        public IEnumerable<SelectListItem> Crusts { get; set; }
        public IEnumerable<SelectListItem> Sauces { get; set; }
        public IEnumerable<SelectListItem> Toppings { get; set; }
    }
}