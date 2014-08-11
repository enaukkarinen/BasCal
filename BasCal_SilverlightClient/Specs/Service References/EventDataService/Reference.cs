﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Specs.EventDataService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EventTypeDTO", Namespace="http://schemas.datacontract.org/2004/07/BasCal_WCF_Host.DTO_Models")]
    [System.SerializableAttribute()]
    public partial class EventTypeDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TypeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeNameField;
        
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
        public int TypeId {
            get {
                return this.TypeIdField;
            }
            set {
                if ((this.TypeIdField.Equals(value) != true)) {
                    this.TypeIdField = value;
                    this.RaisePropertyChanged("TypeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeName {
            get {
                return this.TypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeNameField, value) != true)) {
                    this.TypeNameField = value;
                    this.RaisePropertyChanged("TypeName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UpcomingEventDTO", Namespace="http://schemas.datacontract.org/2004/07/BasCal_WCF_Host.DTO_Models")]
    [System.SerializableAttribute()]
    public partial class UpcomingEventDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid EventIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SummaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TypeIdField;
        
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
        public System.DateTime EndTime {
            get {
                return this.EndTimeField;
            }
            set {
                if ((this.EndTimeField.Equals(value) != true)) {
                    this.EndTimeField = value;
                    this.RaisePropertyChanged("EndTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid EventId {
            get {
                return this.EventIdField;
            }
            set {
                if ((this.EventIdField.Equals(value) != true)) {
                    this.EventIdField = value;
                    this.RaisePropertyChanged("EventId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartTime {
            get {
                return this.StartTimeField;
            }
            set {
                if ((this.StartTimeField.Equals(value) != true)) {
                    this.StartTimeField = value;
                    this.RaisePropertyChanged("StartTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Summary {
            get {
                return this.SummaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SummaryField, value) != true)) {
                    this.SummaryField = value;
                    this.RaisePropertyChanged("Summary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TypeId {
            get {
                return this.TypeIdField;
            }
            set {
                if ((this.TypeIdField.Equals(value) != true)) {
                    this.TypeIdField = value;
                    this.RaisePropertyChanged("TypeId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UpcomingEventShortDTO", Namespace="http://schemas.datacontract.org/2004/07/BasCal_WCF_Host.DTO_Models")]
    [System.SerializableAttribute()]
    public partial class UpcomingEventShortDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid EventIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartTimeField;
        
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
        public System.DateTime EndTime {
            get {
                return this.EndTimeField;
            }
            set {
                if ((this.EndTimeField.Equals(value) != true)) {
                    this.EndTimeField = value;
                    this.RaisePropertyChanged("EndTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid EventId {
            get {
                return this.EventIdField;
            }
            set {
                if ((this.EventIdField.Equals(value) != true)) {
                    this.EventIdField = value;
                    this.RaisePropertyChanged("EventId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartTime {
            get {
                return this.StartTimeField;
            }
            set {
                if ((this.StartTimeField.Equals(value) != true)) {
                    this.StartTimeField = value;
                    this.RaisePropertyChanged("StartTime");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EventDataService.IEventDataService")]
    public interface IEventDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventDataService/FetchEventTypes", ReplyAction="http://tempuri.org/IEventDataService/FetchEventTypesResponse")]
        Specs.EventDataService.EventTypeDTO[] FetchEventTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventDataService/FetchEventTypes", ReplyAction="http://tempuri.org/IEventDataService/FetchEventTypesResponse")]
        System.Threading.Tasks.Task<Specs.EventDataService.EventTypeDTO[]> FetchEventTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventDataService/AddOrUpdateEvent", ReplyAction="http://tempuri.org/IEventDataService/AddOrUpdateEventResponse")]
        string AddOrUpdateEvent(Specs.EventDataService.UpcomingEventDTO eve);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventDataService/AddOrUpdateEvent", ReplyAction="http://tempuri.org/IEventDataService/AddOrUpdateEventResponse")]
        System.Threading.Tasks.Task<string> AddOrUpdateEventAsync(Specs.EventDataService.UpcomingEventDTO eve);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventDataService/FetchEventsByMonth", ReplyAction="http://tempuri.org/IEventDataService/FetchEventsByMonthResponse")]
        Specs.EventDataService.UpcomingEventShortDTO[] FetchEventsByMonth(int m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventDataService/FetchEventsByMonth", ReplyAction="http://tempuri.org/IEventDataService/FetchEventsByMonthResponse")]
        System.Threading.Tasks.Task<Specs.EventDataService.UpcomingEventShortDTO[]> FetchEventsByMonthAsync(int m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventDataService/FetchEventByGuid", ReplyAction="http://tempuri.org/IEventDataService/FetchEventByGuidResponse")]
        Specs.EventDataService.UpcomingEventDTO FetchEventByGuid(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventDataService/FetchEventByGuid", ReplyAction="http://tempuri.org/IEventDataService/FetchEventByGuidResponse")]
        System.Threading.Tasks.Task<Specs.EventDataService.UpcomingEventDTO> FetchEventByGuidAsync(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventDataService/FetchUpcomingEventsShort", ReplyAction="http://tempuri.org/IEventDataService/FetchUpcomingEventsShortResponse")]
        Specs.EventDataService.UpcomingEventShortDTO[] FetchUpcomingEventsShort();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEventDataService/FetchUpcomingEventsShort", ReplyAction="http://tempuri.org/IEventDataService/FetchUpcomingEventsShortResponse")]
        System.Threading.Tasks.Task<Specs.EventDataService.UpcomingEventShortDTO[]> FetchUpcomingEventsShortAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEventDataServiceChannel : Specs.EventDataService.IEventDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EventDataServiceClient : System.ServiceModel.ClientBase<Specs.EventDataService.IEventDataService>, Specs.EventDataService.IEventDataService {
        
        public EventDataServiceClient() {
        }
        
        public EventDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EventDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EventDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Specs.EventDataService.EventTypeDTO[] FetchEventTypes() {
            return base.Channel.FetchEventTypes();
        }
        
        public System.Threading.Tasks.Task<Specs.EventDataService.EventTypeDTO[]> FetchEventTypesAsync() {
            return base.Channel.FetchEventTypesAsync();
        }
        
        public string AddOrUpdateEvent(Specs.EventDataService.UpcomingEventDTO eve) {
            return base.Channel.AddOrUpdateEvent(eve);
        }
        
        public System.Threading.Tasks.Task<string> AddOrUpdateEventAsync(Specs.EventDataService.UpcomingEventDTO eve) {
            return base.Channel.AddOrUpdateEventAsync(eve);
        }
        
        public Specs.EventDataService.UpcomingEventShortDTO[] FetchEventsByMonth(int m) {
            return base.Channel.FetchEventsByMonth(m);
        }
        
        public System.Threading.Tasks.Task<Specs.EventDataService.UpcomingEventShortDTO[]> FetchEventsByMonthAsync(int m) {
            return base.Channel.FetchEventsByMonthAsync(m);
        }
        
        public Specs.EventDataService.UpcomingEventDTO FetchEventByGuid(System.Guid guid) {
            return base.Channel.FetchEventByGuid(guid);
        }
        
        public System.Threading.Tasks.Task<Specs.EventDataService.UpcomingEventDTO> FetchEventByGuidAsync(System.Guid guid) {
            return base.Channel.FetchEventByGuidAsync(guid);
        }
        
        public Specs.EventDataService.UpcomingEventShortDTO[] FetchUpcomingEventsShort() {
            return base.Channel.FetchUpcomingEventsShort();
        }
        
        public System.Threading.Tasks.Task<Specs.EventDataService.UpcomingEventShortDTO[]> FetchUpcomingEventsShortAsync() {
            return base.Channel.FetchUpcomingEventsShortAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EventDataService.IClientAccessPolicy")]
    public interface IClientAccessPolicy {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientAccessPolicy/GetClientAccessPolicy", ReplyAction="http://tempuri.org/IClientAccessPolicy/GetClientAccessPolicyResponse")]
        System.IO.Stream GetClientAccessPolicy();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClientAccessPolicy/GetClientAccessPolicy", ReplyAction="http://tempuri.org/IClientAccessPolicy/GetClientAccessPolicyResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetClientAccessPolicyAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientAccessPolicyChannel : Specs.EventDataService.IClientAccessPolicy, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientAccessPolicyClient : System.ServiceModel.ClientBase<Specs.EventDataService.IClientAccessPolicy>, Specs.EventDataService.IClientAccessPolicy {
        
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