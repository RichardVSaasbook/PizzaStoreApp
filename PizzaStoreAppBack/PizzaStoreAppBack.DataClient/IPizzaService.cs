﻿using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PizzaStoreAppBack.DataClient {
    [ServiceContract]
    public interface IPizzaService {
        [OperationContract]
        bool CreateOrder(int storeId, int customerId, List<PizzaDAO> pizzasDAOs, decimal subTotal, decimal taxTotal, decimal total);

        [OperationContract]
        List<PizzaDAO> ListPizzasInOrder(int orderId);
    }
}
