﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfClient.CallbackExample.CalculatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples", ConfigurationName="CalculatorService.ICalculatorDuplex", CallbackContract=typeof(WcfClient.CallbackExample.CalculatorService.ICalculatorDuplexCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICalculatorDuplex {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/Clear")]
        void Clear();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/Clear")]
        System.Threading.Tasks.Task ClearAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/AddTo")]
        void AddTo(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/AddTo")]
        System.Threading.Tasks.Task AddToAsync(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/SubtractFrom")]
        void SubtractFrom(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/SubtractFrom")]
        System.Threading.Tasks.Task SubtractFromAsync(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/MultiplyBy")]
        void MultiplyBy(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/MultiplyBy")]
        System.Threading.Tasks.Task MultiplyByAsync(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/DivideBy")]
        void DivideBy(double n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/DivideBy")]
        System.Threading.Tasks.Task DivideByAsync(double n);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorDuplexCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/Equals")]
        void Equals(double result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ICalculatorDuplex/Equation")]
        void Equation(string eqn);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorDuplexChannel : WcfClient.CallbackExample.CalculatorService.ICalculatorDuplex, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorDuplexClient : System.ServiceModel.DuplexClientBase<WcfClient.CallbackExample.CalculatorService.ICalculatorDuplex>, WcfClient.CallbackExample.CalculatorService.ICalculatorDuplex {
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorDuplexClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Clear() {
            base.Channel.Clear();
        }
        
        public System.Threading.Tasks.Task ClearAsync() {
            return base.Channel.ClearAsync();
        }
        
        public void AddTo(double n) {
            base.Channel.AddTo(n);
        }
        
        public System.Threading.Tasks.Task AddToAsync(double n) {
            return base.Channel.AddToAsync(n);
        }
        
        public void SubtractFrom(double n) {
            base.Channel.SubtractFrom(n);
        }
        
        public System.Threading.Tasks.Task SubtractFromAsync(double n) {
            return base.Channel.SubtractFromAsync(n);
        }
        
        public void MultiplyBy(double n) {
            base.Channel.MultiplyBy(n);
        }
        
        public System.Threading.Tasks.Task MultiplyByAsync(double n) {
            return base.Channel.MultiplyByAsync(n);
        }
        
        public void DivideBy(double n) {
            base.Channel.DivideBy(n);
        }
        
        public System.Threading.Tasks.Task DivideByAsync(double n) {
            return base.Channel.DivideByAsync(n);
        }
    }
}
