﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleTest.ServiceSolutionRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceSolutionRef.IDB_Service")]
    public interface IDB_Service {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDB_Service/FetchThroughClassLibAndFromDBAsString", ReplyAction="http://tempuri.org/IDB_Service/FetchThroughClassLibAndFromDBAsStringResponse")]
        string[] FetchThroughClassLibAndFromDBAsString();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDB_Service/FetchThroughClassLibAndFromDBAsString", ReplyAction="http://tempuri.org/IDB_Service/FetchThroughClassLibAndFromDBAsStringResponse")]
        System.Threading.Tasks.Task<string[]> FetchThroughClassLibAndFromDBAsStringAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDB_Service/FetchThroughClassLibAndFromDBAsTable", ReplyAction="http://tempuri.org/IDB_Service/FetchThroughClassLibAndFromDBAsTableResponse")]
        DB_Solution.Testitaulu[] FetchThroughClassLibAndFromDBAsTable();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDB_Service/FetchThroughClassLibAndFromDBAsTable", ReplyAction="http://tempuri.org/IDB_Service/FetchThroughClassLibAndFromDBAsTableResponse")]
        System.Threading.Tasks.Task<DB_Solution.Testitaulu[]> FetchThroughClassLibAndFromDBAsTableAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDB_Service/GetData", ReplyAction="http://tempuri.org/IDB_Service/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDB_Service/GetData", ReplyAction="http://tempuri.org/IDB_Service/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDB_Service/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IDB_Service/GetDataUsingDataContractResponse")]
        Service_Solution.CompositeType GetDataUsingDataContract(Service_Solution.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDB_Service/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IDB_Service/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Service_Solution.CompositeType> GetDataUsingDataContractAsync(Service_Solution.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDB_ServiceChannel : ConsoleTest.ServiceSolutionRef.IDB_Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DB_ServiceClient : System.ServiceModel.ClientBase<ConsoleTest.ServiceSolutionRef.IDB_Service>, ConsoleTest.ServiceSolutionRef.IDB_Service {
        
        public DB_ServiceClient() {
        }
        
        public DB_ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DB_ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DB_ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DB_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] FetchThroughClassLibAndFromDBAsString() {
            return base.Channel.FetchThroughClassLibAndFromDBAsString();
        }
        
        public System.Threading.Tasks.Task<string[]> FetchThroughClassLibAndFromDBAsStringAsync() {
            return base.Channel.FetchThroughClassLibAndFromDBAsStringAsync();
        }
        
        public DB_Solution.Testitaulu[] FetchThroughClassLibAndFromDBAsTable() {
            return base.Channel.FetchThroughClassLibAndFromDBAsTable();
        }
        
        public System.Threading.Tasks.Task<DB_Solution.Testitaulu[]> FetchThroughClassLibAndFromDBAsTableAsync() {
            return base.Channel.FetchThroughClassLibAndFromDBAsTableAsync();
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Service_Solution.CompositeType GetDataUsingDataContract(Service_Solution.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Service_Solution.CompositeType> GetDataUsingDataContractAsync(Service_Solution.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceSolutionRef.IClientAccessPolicy")]
    public interface IClientAccessPolicy {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientAccessPolicy/GetClientAccessPolicy", ReplyAction="http://tempuri.org/IClientAccessPolicy/GetClientAccessPolicyResponse")]
        System.IO.Stream GetClientAccessPolicy();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientAccessPolicy/GetClientAccessPolicy", ReplyAction="http://tempuri.org/IClientAccessPolicy/GetClientAccessPolicyResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetClientAccessPolicyAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientAccessPolicyChannel : ConsoleTest.ServiceSolutionRef.IClientAccessPolicy, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientAccessPolicyClient : System.ServiceModel.ClientBase<ConsoleTest.ServiceSolutionRef.IClientAccessPolicy>, ConsoleTest.ServiceSolutionRef.IClientAccessPolicy {
        
        public ClientAccessPolicyClient() {
        }
        
        public ClientAccessPolicyClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientAccessPolicyClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientAccessPolicyClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientAccessPolicyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.IO.Stream GetClientAccessPolicy() {
            return base.Channel.GetClientAccessPolicy();
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetClientAccessPolicyAsync() {
            return base.Channel.GetClientAccessPolicyAsync();
        }
    }
}
