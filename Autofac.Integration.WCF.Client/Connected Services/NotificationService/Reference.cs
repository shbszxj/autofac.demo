﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Autofac.Integration.WCF.Client.NotificationService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NotificationService.INotificationService", CallbackContract=typeof(Autofac.Integration.WCF.Client.NotificationService.INotificationServiceCallback))]
    public interface INotificationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotificationService/TestCallbackMethod", ReplyAction="http://tempuri.org/INotificationService/TestCallbackMethodResponse")]
        void TestCallbackMethod();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INotificationService/TestCallbackMethod", ReplyAction="http://tempuri.org/INotificationService/TestCallbackMethodResponse")]
        System.Threading.Tasks.Task TestCallbackMethodAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INotificationServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/INotificationService/Send")]
        void Send(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INotificationServiceChannel : Autofac.Integration.WCF.Client.NotificationService.INotificationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NotificationServiceClient : System.ServiceModel.DuplexClientBase<Autofac.Integration.WCF.Client.NotificationService.INotificationService>, Autofac.Integration.WCF.Client.NotificationService.INotificationService {
        
        public NotificationServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public NotificationServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public NotificationServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public NotificationServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public NotificationServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void TestCallbackMethod() {
            base.Channel.TestCallbackMethod();
        }
        
        public System.Threading.Tasks.Task TestCallbackMethodAsync() {
            return base.Channel.TestCallbackMethodAsync();
        }
    }
}