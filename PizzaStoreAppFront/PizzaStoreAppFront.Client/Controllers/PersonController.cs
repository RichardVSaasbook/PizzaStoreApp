using PizzaStoreAppFront.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreAppFront.Client.Controllers {
    public class PersonController : Controller {
        private IPizzaStoreRepository repository;

        public PersonController(IPizzaStoreRepository repository) {
            this.repository = repository;
        }

        public ActionResult Index() {
            return View(repository.ListPeople());
        }
    }
}