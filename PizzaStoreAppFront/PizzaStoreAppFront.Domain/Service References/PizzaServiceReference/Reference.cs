﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaStoreAppFront.Domain.PizzaServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PizzaDAO", Namespace="http://schemas.datacontract.org/2004/07/PizzaStoreAppBack.DataClient.Models")]
    [System.SerializableAttribute()]
    public partial class PizzaDAO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PizzaIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PizzaStoreAppFront.Domain.PizzaServiceReference.SizeDAO SizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime UpdatedDateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedDate {
            get {
                return this.CreatedDateField;
            }
            set {
                if ((this.CreatedDateField.Equals(value) != true)) {
                    this.CreatedDateField = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PizzaId {
            get {
                return this.PizzaIdField;
            }
            set {
                if ((this.PizzaIdField.Equals(value) != true)) {
                    this.PizzaIdField = value;
                    this.RaisePropertyChanged("PizzaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PizzaStoreAppFront.Domain.PizzaServiceReference.SizeDAO Size {
            get {
                return this.SizeField;
            }
            set {
                if ((object.ReferenceEquals(this.SizeField, value) != true)) {
                    this.SizeField = value;
                    this.RaisePropertyChanged("Size");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime UpdatedDate {
            get {
                return this.UpdatedDateField;
            }
            set {
                if ((this.UpdatedDateField.Equals(value) != true)) {
                    this.UpdatedDateField = value;
                    this.RaisePropertyChanged("UpdatedDate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SizeDAO", Namespace="http://schemas.datacontract.org/2004/07/PizzaStoreAppBack.DataClient.Models")]
    [System.SerializableAttribute()]
    public partial class SizeDAO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DimensionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SizeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime UpdatedDateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedDate {
            get {
                return this.CreatedDateField;
            }
            set {
                if ((this.CreatedDateField.Equals(value) != true)) {
                    this.CreatedDateField = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Dimension {
            get {
                return this.DimensionField;
            }
            set {
                if ((this.DimensionField.Equals(value) != true)) {
                    this.DimensionField = value;
                    this.RaisePropertyChanged("Dimension");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SizeId {
            get {
                return this.SizeIdField;
            }
            set {
                if ((this.SizeIdField.Equals(value) != true)) {
                    this.SizeIdField = value;
                    this.RaisePropertyChanged("SizeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime UpdatedDate {
            get {
                return this.UpdatedDateField;
            }
            set {
                if ((this.UpdatedDateField.Equals(value) != true)) {
                    this.UpdatedDateField = value;
                    this.RaisePropertyChanged("UpdatedDate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PizzaServiceReference.IPizzaService")]
    public interface IPizzaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/CreateOrder", ReplyAction="http://tempuri.org/IPizzaService/CreateOrderResponse")]
        bool CreateOrder(int customerId, PizzaStoreAppFront.Domain.PizzaServiceReference.PizzaDAO[] pizzaDAOs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/CreateOrder", ReplyAction="http://tempuri.org/IPizzaService/CreateOrderResponse")]
        System.Threading.Tasks.Task<bool> CreateOrderAsync(int customerId, PizzaStoreAppFront.Domain.PizzaServiceReference.PizzaDAO[] pizzaDAOs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/ListPizzasInOrder", ReplyAction="http://tempuri.org/IPizzaService/ListPizzasInOrderResponse")]
        PizzaStoreAppFront.Domain.PizzaServiceReference.PizzaDAO[] ListPizzasInOrder(int orderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPizzaService/ListPizzasInOrder", ReplyAction="http://tempuri.org/IPizzaService/ListPizzasInOrderResponse")]
        System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.PizzaServiceReference.PizzaDAO[]> ListPizzasInOrderAsync(int orderId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPizzaServiceChannel : PizzaStoreAppFront.Domain.PizzaServiceReference.IPizzaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PizzaServiceClient : System.ServiceModel.ClientBase<PizzaStoreAppFront.Domain.PizzaServiceReference.IPizzaService>, PizzaStoreAppFront.Domain.PizzaServiceReference.IPizzaService {
        
        public PizzaServiceClient() {
        }
        
        public PizzaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PizzaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PizzaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CreateOrder(int customerId, PizzaStoreAppFront.Domain.PizzaServiceReference.PizzaDAO[] pizzaDAOs) {
            return base.Channel.CreateOrder(customerId, pizzaDAOs);
        }
        
        public System.Threading.Tasks.Task<bool> CreateOrderAsync(int customerId, PizzaStoreAppFront.Domain.PizzaServiceReference.PizzaDAO[] pizzaDAOs) {
            return base.Channel.CreateOrderAsync(customerId, pizzaDAOs);
        }
        
        public PizzaStoreAppFront.Domain.PizzaServiceReference.PizzaDAO[] ListPizzasInOrder(int orderId) {
            return base.Channel.ListPizzasInOrder(orderId);
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.PizzaServiceReference.PizzaDAO[]> ListPizzasInOrderAsync(int orderId) {
            return base.Channel.ListPizzasInOrderAsync(orderId);
        }
    }
}
