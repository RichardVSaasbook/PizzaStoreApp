using PizzaStoreAppBack.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PizzaStoreAppBack.DataClient {
    [ServiceContract]
    public interface ISizeService {
        [OperationContract]
        List<SizeDAO> ListSizes();

        [OperationContract]
        SizeDAO GetSize(int sizeId);
    }
}
