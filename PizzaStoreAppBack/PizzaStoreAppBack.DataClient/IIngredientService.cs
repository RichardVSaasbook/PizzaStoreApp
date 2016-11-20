using PizzaStoreAppBack.DataClient.Models;
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
        List<IngredientDAO> ListCrusts();

        [OperationContract]
        List<IngredientDAO> ListSauces();

        [OperationContract]
        List<IngredientDAO> ListCheeses();

        [OperationContract]
        List<IngredientDAO> ListToppings();

        [OperationContract]
        IngredientDAO GetIngredient(int ingredientId);
    }
}
