using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PizzaStoreAppBack.DataClient {
    [ServiceContract]
    public interface IPizzaDataService {
        [OperationContract]
        AddressDAO GetAddress(int addressId);

        [OperationContract]
        PhoneDAO GetPhone(int phoneId);

        [OperationContract]
        StoreDAO GetStore(int storeId);

        [OperationContract]
        PersonDAO GetPerson(int personId);

        [OperationContract]
        List<StoreDAO> ListStores();

        [OperationContract]
        List<OrderDAO> ListStoreOrders(int storeId);

        [OperationContract]
        List<PersonDAO> ListPeople();
    }
}
