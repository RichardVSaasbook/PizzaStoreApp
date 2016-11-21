﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaStoreAppFront.Api.IngredientServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IngredientServiceReference.IIngredientService")]
    public interface IIngredientService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/ListCrusts", ReplyAction="http://tempuri.org/IIngredientService/ListCrustsResponse")]
        PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[] ListCrusts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/ListCrusts", ReplyAction="http://tempuri.org/IIngredientService/ListCrustsResponse")]
        System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[]> ListCrustsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/ListSauces", ReplyAction="http://tempuri.org/IIngredientService/ListSaucesResponse")]
        PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[] ListSauces();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/ListSauces", ReplyAction="http://tempuri.org/IIngredientService/ListSaucesResponse")]
        System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[]> ListSaucesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/ListCheeses", ReplyAction="http://tempuri.org/IIngredientService/ListCheesesResponse")]
        PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[] ListCheeses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/ListCheeses", ReplyAction="http://tempuri.org/IIngredientService/ListCheesesResponse")]
        System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[]> ListCheesesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/ListToppings", ReplyAction="http://tempuri.org/IIngredientService/ListToppingsResponse")]
        PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[] ListToppings();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/ListToppings", ReplyAction="http://tempuri.org/IIngredientService/ListToppingsResponse")]
        System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[]> ListToppingsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/GetIngredient", ReplyAction="http://tempuri.org/IIngredientService/GetIngredientResponse")]
        PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO GetIngredient(int ingredientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/GetIngredient", ReplyAction="http://tempuri.org/IIngredientService/GetIngredientResponse")]
        System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO> GetIngredientAsync(int ingredientId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIngredientServiceChannel : PizzaStoreAppFront.Api.IngredientServiceReference.IIngredientService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IngredientServiceClient : System.ServiceModel.ClientBase<PizzaStoreAppFront.Api.IngredientServiceReference.IIngredientService>, PizzaStoreAppFront.Api.IngredientServiceReference.IIngredientService {
        
        public IngredientServiceClient() {
        }
        
        public IngredientServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IngredientServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IngredientServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IngredientServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[] ListCrusts() {
            return base.Channel.ListCrusts();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[]> ListCrustsAsync() {
            return base.Channel.ListCrustsAsync();
        }
        
        public PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[] ListSauces() {
            return base.Channel.ListSauces();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[]> ListSaucesAsync() {
            return base.Channel.ListSaucesAsync();
        }
        
        public PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[] ListCheeses() {
            return base.Channel.ListCheeses();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[]> ListCheesesAsync() {
            return base.Channel.ListCheesesAsync();
        }
        
        public PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[] ListToppings() {
            return base.Channel.ListToppings();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO[]> ListToppingsAsync() {
            return base.Channel.ListToppingsAsync();
        }
        
        public PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO GetIngredient(int ingredientId) {
            return base.Channel.GetIngredient(ingredientId);
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.IngredientServiceReference.IngredientDAO> GetIngredientAsync(int ingredientId) {
            return base.Channel.GetIngredientAsync(ingredientId);
        }
    }
}