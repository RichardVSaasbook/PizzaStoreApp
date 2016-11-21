using PizzaStoreAppBack.DataClient.Models;
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
        bool CreateOrder(int customerId, List<PizzaDAO> pizzaDAOs);

        [OperationContract]
        List<PizzaDAO> ListPizzasInOrder(int orderId);
    }
}
