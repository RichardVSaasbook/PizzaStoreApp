﻿using PizzaStoreAppFront.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreAppFront.Domain.Abstract {
    public interface IPizzaStoreRepository {
        IEnumerable<Ingredient> ListIngredients(string type);
        Ingredient GetIngredient(int ingredientId);
        IEnumerable<Size> ListSizes();
        Size GetSize(int sizeId);
        List<Pizza> ListPizzasInOrder(int orderId);
        Store GetNearestStore(Address address);
        List<Store> ListStores();
        List<Person> ListPeople();
        List<Order> ListStoreOrders(int storeId);
        bool SubmitOrder(int customerId, int storeId, List<Pizza> pizzas, decimal subTotal, decimal taxTotal, decimal total);
    }
}
