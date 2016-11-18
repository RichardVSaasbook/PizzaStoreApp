using PizzaStoreAppBack.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PizzaStoreAppBack.DataClient {
    [ServiceContract]
    public interface IIngredientService {
        [OperationContract]
        List<Ingredient> ListCrusts();

        [OperationContract]
        List<Ingredient> ListSauces();

        [OperationContract]
        List<Ingredient> ListCheeses();

        [OperationContract]
        List<Ingredient> ListToppings();
    }
}
