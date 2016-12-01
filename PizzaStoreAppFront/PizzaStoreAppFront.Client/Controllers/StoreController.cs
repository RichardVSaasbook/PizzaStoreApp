using PizzaStoreAppFront.Client.Models;
using PizzaStoreAppFront.Domain.Abstract;
using PizzaStoreAppFront.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreAppFront.Client.Controllers
{
    public class StoreController : Controller
    {
        private readonly IPizzaStoreRepository repository;

        public StoreController(IPizzaStoreRepository repository) {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            return View(GetStoreVM(0));
        }

        public ActionResult Show(int storeId) {
            return View(new StoreOrdersViewModel {
                Orders = repository.ListStoreOrders(storeId),
                StoreViewModel = GetStoreVM(storeId)
            });
        }

        private StoreViewModel GetStoreVM(int storeId) {
            return new StoreViewModel {
                Stores = repository.ListStores(),
                CurrentStoreId = storeId
            };
        }
    }
}