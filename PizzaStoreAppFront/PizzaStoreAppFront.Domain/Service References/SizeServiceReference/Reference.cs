﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaStoreAppFront.Domain.SizeServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SizeServiceReference.ISizeService")]
    public interface ISizeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISizeService/ListSizes", ReplyAction="http://tempuri.org/ISizeService/ListSizesResponse")]
        PizzaStoreAppFront.Domain.SizeServiceReference.SizeDAO[] ListSizes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISizeService/ListSizes", ReplyAction="http://tempuri.org/ISizeService/ListSizesResponse")]
        System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.SizeServiceReference.SizeDAO[]> ListSizesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISizeService/GetSize", ReplyAction="http://tempuri.org/ISizeService/GetSizeResponse")]
        PizzaStoreAppFront.Domain.SizeServiceReference.SizeDAO GetSize(int sizeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISizeService/GetSize", ReplyAction="http://tempuri.org/ISizeService/GetSizeResponse")]
        System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.SizeServiceReference.SizeDAO> GetSizeAsync(int sizeId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISizeServiceChannel : PizzaStoreAppFront.Domain.SizeServiceReference.ISizeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SizeServiceClient : System.ServiceModel.ClientBase<PizzaStoreAppFront.Domain.SizeServiceReference.ISizeService>, PizzaStoreAppFront.Domain.SizeServiceReference.ISizeService {
        
        public SizeServiceClient() {
        }
        
        public SizeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SizeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SizeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SizeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PizzaStoreAppFront.Domain.SizeServiceReference.SizeDAO[] ListSizes() {
            return base.Channel.ListSizes();
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.SizeServiceReference.SizeDAO[]> ListSizesAsync() {
            return base.Channel.ListSizesAsync();
        }
        
        public PizzaStoreAppFront.Domain.SizeServiceReference.SizeDAO GetSize(int sizeId) {
            return base.Channel.GetSize(sizeId);
        }
        
        public System.Threading.Tasks.Task<PizzaStoreAppFront.Domain.SizeServiceReference.SizeDAO> GetSizeAsync(int sizeId) {
            return base.Channel.GetSizeAsync(sizeId);
        }
    }
}