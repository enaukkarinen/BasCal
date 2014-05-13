﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace Harkkaprojekti.WCF_Solution_Ref {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UpcomingEventDTO", Namespace="http://schemas.datacontract.org/2004/07/Service_Solution.DTO_Models")]
    public partial class UpcomingEventDTO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.DateTime EndTimeField;
        
        private string LocationField;
        
        private string NameField;
        
        private System.DateTime StartTimeField;
        
        private string SummaryField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EventDTO", Namespace="http://schemas.datacontract.org/2004/07/Service_Solution")]
    public partial class EventDTO : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Guid EventIdField;
        
        private int TypeIdField;
        
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCF_Solution_Ref.IDB_Service")]
    public interface IDB_Service {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDB_Service/FetchUpcomingEvents", ReplyAction="http://tempuri.org/IDB_Service/FetchUpcomingEventsResponse")]
        System.IAsyncResult BeginFetchUpcomingEvents(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.UpcomingEventDTO> EndFetchUpcomingEvents(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IDB_Service/FetchEvents", ReplyAction="http://tempuri.org/IDB_Service/FetchEventsResponse")]
        System.IAsyncResult BeginFetchEvents(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.EventDTO> EndFetchEvents(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDB_ServiceChannel : Harkkaprojekti.WCF_Solution_Ref.IDB_Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FetchUpcomingEventsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public FetchUpcomingEventsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.UpcomingEventDTO> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.UpcomingEventDTO>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FetchEventsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public FetchEventsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.EventDTO> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.EventDTO>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DB_ServiceClient : System.ServiceModel.ClientBase<Harkkaprojekti.WCF_Solution_Ref.IDB_Service>, Harkkaprojekti.WCF_Solution_Ref.IDB_Service {
        
        private BeginOperationDelegate onBeginFetchUpcomingEventsDelegate;
        
        private EndOperationDelegate onEndFetchUpcomingEventsDelegate;
        
        private System.Threading.SendOrPostCallback onFetchUpcomingEventsCompletedDelegate;
        
        private BeginOperationDelegate onBeginFetchEventsDelegate;
        
        private EndOperationDelegate onEndFetchEventsDelegate;
        
        private System.Threading.SendOrPostCallback onFetchEventsCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
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
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<FetchUpcomingEventsCompletedEventArgs> FetchUpcomingEventsCompleted;
        
        public event System.EventHandler<FetchEventsCompletedEventArgs> FetchEventsCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Harkkaprojekti.WCF_Solution_Ref.IDB_Service.BeginFetchUpcomingEvents(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginFetchUpcomingEvents(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.UpcomingEventDTO> Harkkaprojekti.WCF_Solution_Ref.IDB_Service.EndFetchUpcomingEvents(System.IAsyncResult result) {
            return base.Channel.EndFetchUpcomingEvents(result);
        }
        
        private System.IAsyncResult OnBeginFetchUpcomingEvents(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((Harkkaprojekti.WCF_Solution_Ref.IDB_Service)(this)).BeginFetchUpcomingEvents(callback, asyncState);
        }
        
        private object[] OnEndFetchUpcomingEvents(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.UpcomingEventDTO> retVal = ((Harkkaprojekti.WCF_Solution_Ref.IDB_Service)(this)).EndFetchUpcomingEvents(result);
            return new object[] {
                    retVal};
        }
        
        private void OnFetchUpcomingEventsCompleted(object state) {
            if ((this.FetchUpcomingEventsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.FetchUpcomingEventsCompleted(this, new FetchUpcomingEventsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void FetchUpcomingEventsAsync() {
            this.FetchUpcomingEventsAsync(null);
        }
        
        public void FetchUpcomingEventsAsync(object userState) {
            if ((this.onBeginFetchUpcomingEventsDelegate == null)) {
                this.onBeginFetchUpcomingEventsDelegate = new BeginOperationDelegate(this.OnBeginFetchUpcomingEvents);
            }
            if ((this.onEndFetchUpcomingEventsDelegate == null)) {
                this.onEndFetchUpcomingEventsDelegate = new EndOperationDelegate(this.OnEndFetchUpcomingEvents);
            }
            if ((this.onFetchUpcomingEventsCompletedDelegate == null)) {
                this.onFetchUpcomingEventsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnFetchUpcomingEventsCompleted);
            }
            base.InvokeAsync(this.onBeginFetchUpcomingEventsDelegate, null, this.onEndFetchUpcomingEventsDelegate, this.onFetchUpcomingEventsCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Harkkaprojekti.WCF_Solution_Ref.IDB_Service.BeginFetchEvents(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginFetchEvents(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.EventDTO> Harkkaprojekti.WCF_Solution_Ref.IDB_Service.EndFetchEvents(System.IAsyncResult result) {
            return base.Channel.EndFetchEvents(result);
        }
        
        private System.IAsyncResult OnBeginFetchEvents(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((Harkkaprojekti.WCF_Solution_Ref.IDB_Service)(this)).BeginFetchEvents(callback, asyncState);
        }
        
        private object[] OnEndFetchEvents(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.EventDTO> retVal = ((Harkkaprojekti.WCF_Solution_Ref.IDB_Service)(this)).EndFetchEvents(result);
            return new object[] {
                    retVal};
        }
        
        private void OnFetchEventsCompleted(object state) {
            if ((this.FetchEventsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.FetchEventsCompleted(this, new FetchEventsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void FetchEventsAsync() {
            this.FetchEventsAsync(null);
        }
        
        public void FetchEventsAsync(object userState) {
            if ((this.onBeginFetchEventsDelegate == null)) {
                this.onBeginFetchEventsDelegate = new BeginOperationDelegate(this.OnBeginFetchEvents);
            }
            if ((this.onEndFetchEventsDelegate == null)) {
                this.onEndFetchEventsDelegate = new EndOperationDelegate(this.OnEndFetchEvents);
            }
            if ((this.onFetchEventsCompletedDelegate == null)) {
                this.onFetchEventsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnFetchEventsCompleted);
            }
            base.InvokeAsync(this.onBeginFetchEventsDelegate, null, this.onEndFetchEventsDelegate, this.onFetchEventsCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override Harkkaprojekti.WCF_Solution_Ref.IDB_Service CreateChannel() {
            return new DB_ServiceClientChannel(this);
        }
        
        private class DB_ServiceClientChannel : ChannelBase<Harkkaprojekti.WCF_Solution_Ref.IDB_Service>, Harkkaprojekti.WCF_Solution_Ref.IDB_Service {
            
            public DB_ServiceClientChannel(System.ServiceModel.ClientBase<Harkkaprojekti.WCF_Solution_Ref.IDB_Service> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginFetchUpcomingEvents(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("FetchUpcomingEvents", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.UpcomingEventDTO> EndFetchUpcomingEvents(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.UpcomingEventDTO> _result = ((System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.UpcomingEventDTO>)(base.EndInvoke("FetchUpcomingEvents", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginFetchEvents(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("FetchEvents", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.EventDTO> EndFetchEvents(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.EventDTO> _result = ((System.Collections.ObjectModel.ObservableCollection<Harkkaprojekti.WCF_Solution_Ref.EventDTO>)(base.EndInvoke("FetchEvents", _args, result)));
                return _result;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCF_Solution_Ref.IClientAccessPolicy")]
    public interface IClientAccessPolicy {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IClientAccessPolicy/GetClientAccessPolicy", ReplyAction="http://tempuri.org/IClientAccessPolicy/GetClientAccessPolicyResponse")]
        System.IAsyncResult BeginGetClientAccessPolicy(System.AsyncCallback callback, object asyncState);
        
        byte[] EndGetClientAccessPolicy(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientAccessPolicyChannel : Harkkaprojekti.WCF_Solution_Ref.IClientAccessPolicy, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetClientAccessPolicyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetClientAccessPolicyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public byte[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientAccessPolicyClient : System.ServiceModel.ClientBase<Harkkaprojekti.WCF_Solution_Ref.IClientAccessPolicy>, Harkkaprojekti.WCF_Solution_Ref.IClientAccessPolicy {
        
        private BeginOperationDelegate onBeginGetClientAccessPolicyDelegate;
        
        private EndOperationDelegate onEndGetClientAccessPolicyDelegate;
        
        private System.Threading.SendOrPostCallback onGetClientAccessPolicyCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
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
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetClientAccessPolicyCompletedEventArgs> GetClientAccessPolicyCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Harkkaprojekti.WCF_Solution_Ref.IClientAccessPolicy.BeginGetClientAccessPolicy(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetClientAccessPolicy(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        byte[] Harkkaprojekti.WCF_Solution_Ref.IClientAccessPolicy.EndGetClientAccessPolicy(System.IAsyncResult result) {
            return base.Channel.EndGetClientAccessPolicy(result);
        }
        
        private System.IAsyncResult OnBeginGetClientAccessPolicy(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((Harkkaprojekti.WCF_Solution_Ref.IClientAccessPolicy)(this)).BeginGetClientAccessPolicy(callback, asyncState);
        }
        
        private object[] OnEndGetClientAccessPolicy(System.IAsyncResult result) {
            byte[] retVal = ((Harkkaprojekti.WCF_Solution_Ref.IClientAccessPolicy)(this)).EndGetClientAccessPolicy(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetClientAccessPolicyCompleted(object state) {
            if ((this.GetClientAccessPolicyCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetClientAccessPolicyCompleted(this, new GetClientAccessPolicyCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetClientAccessPolicyAsync() {
            this.GetClientAccessPolicyAsync(null);
        }
        
        public void GetClientAccessPolicyAsync(object userState) {
            if ((this.onBeginGetClientAccessPolicyDelegate == null)) {
                this.onBeginGetClientAccessPolicyDelegate = new BeginOperationDelegate(this.OnBeginGetClientAccessPolicy);
            }
            if ((this.onEndGetClientAccessPolicyDelegate == null)) {
                this.onEndGetClientAccessPolicyDelegate = new EndOperationDelegate(this.OnEndGetClientAccessPolicy);
            }
            if ((this.onGetClientAccessPolicyCompletedDelegate == null)) {
                this.onGetClientAccessPolicyCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetClientAccessPolicyCompleted);
            }
            base.InvokeAsync(this.onBeginGetClientAccessPolicyDelegate, null, this.onEndGetClientAccessPolicyDelegate, this.onGetClientAccessPolicyCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override Harkkaprojekti.WCF_Solution_Ref.IClientAccessPolicy CreateChannel() {
            return new ClientAccessPolicyClientChannel(this);
        }
        
        private class ClientAccessPolicyClientChannel : ChannelBase<Harkkaprojekti.WCF_Solution_Ref.IClientAccessPolicy>, Harkkaprojekti.WCF_Solution_Ref.IClientAccessPolicy {
            
            public ClientAccessPolicyClientChannel(System.ServiceModel.ClientBase<Harkkaprojekti.WCF_Solution_Ref.IClientAccessPolicy> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetClientAccessPolicy(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetClientAccessPolicy", _args, callback, asyncState);
                return _result;
            }
            
            public byte[] EndGetClientAccessPolicy(System.IAsyncResult result) {
                object[] _args = new object[0];
                byte[] _result = ((byte[])(base.EndInvoke("GetClientAccessPolicy", _args, result)));
                return _result;
            }
        }
    }
}
