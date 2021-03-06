﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.AdventureWorks_WcfService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/WcfService.AdventureWorks.Models")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/WcfService.AdventureWorks")]
    [System.SerializableAttribute()]
    public partial class CustomerNotFoundFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
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
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdventureWorks_WcfService.IAdventureWorksService")]
    public interface IAdventureWorksService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdventureWorksService/GetCustomerName", ReplyAction="http://tempuri.org/IAdventureWorksService/GetCustomerNameResponse")]
        string GetCustomerName(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdventureWorksService/GetCustomerName", ReplyAction="http://tempuri.org/IAdventureWorksService/GetCustomerNameResponse")]
        System.Threading.Tasks.Task<string> GetCustomerNameAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdventureWorksService/GetCustomersWithOrders", ReplyAction="http://tempuri.org/IAdventureWorksService/GetCustomersWithOrdersResponse")]
        WebApplication1.AdventureWorks_WcfService.Customer[] GetCustomersWithOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdventureWorksService/GetCustomersWithOrders", ReplyAction="http://tempuri.org/IAdventureWorksService/GetCustomersWithOrdersResponse")]
        System.Threading.Tasks.Task<WebApplication1.AdventureWorks_WcfService.Customer[]> GetCustomersWithOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdventureWorksService/GetCustomerWithFaultHandling", ReplyAction="http://tempuri.org/IAdventureWorksService/GetCustomerWithFaultHandlingResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WebApplication1.AdventureWorks_WcfService.CustomerNotFoundFault), Action="http://tempuri.org/IAdventureWorksService/GetCustomerWithFaultHandlingCustomerNot" +
            "FoundFaultFault", Name="CustomerNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/WcfService.AdventureWorks")]
        WebApplication1.AdventureWorks_WcfService.Customer GetCustomerWithFaultHandling(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdventureWorksService/GetCustomerWithFaultHandling", ReplyAction="http://tempuri.org/IAdventureWorksService/GetCustomerWithFaultHandlingResponse")]
        System.Threading.Tasks.Task<WebApplication1.AdventureWorks_WcfService.Customer> GetCustomerWithFaultHandlingAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdventureWorksServiceChannel : WebApplication1.AdventureWorks_WcfService.IAdventureWorksService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdventureWorksServiceClient : System.ServiceModel.ClientBase<WebApplication1.AdventureWorks_WcfService.IAdventureWorksService>, WebApplication1.AdventureWorks_WcfService.IAdventureWorksService {
        
        public AdventureWorksServiceClient() {
        }
        
        public AdventureWorksServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdventureWorksServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdventureWorksServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdventureWorksServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetCustomerName(int id) {
            return base.Channel.GetCustomerName(id);
        }
        
        public System.Threading.Tasks.Task<string> GetCustomerNameAsync(int id) {
            return base.Channel.GetCustomerNameAsync(id);
        }
        
        public WebApplication1.AdventureWorks_WcfService.Customer[] GetCustomersWithOrders() {
            return base.Channel.GetCustomersWithOrders();
        }
        
        public System.Threading.Tasks.Task<WebApplication1.AdventureWorks_WcfService.Customer[]> GetCustomersWithOrdersAsync() {
            return base.Channel.GetCustomersWithOrdersAsync();
        }
        
        public WebApplication1.AdventureWorks_WcfService.Customer GetCustomerWithFaultHandling(int id) {
            return base.Channel.GetCustomerWithFaultHandling(id);
        }
        
        public System.Threading.Tasks.Task<WebApplication1.AdventureWorks_WcfService.Customer> GetCustomerWithFaultHandlingAsync(int id) {
            return base.Channel.GetCustomerWithFaultHandlingAsync(id);
        }
    }
}
