﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chc.SiteService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SICLookup", Namespace="http://schemas.datacontract.org/2004/07/ChcObjects")]
    [System.SerializableAttribute()]
    public partial class SICLookup : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DivisionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IndustryGroupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MajorGroupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SICField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Division {
            get {
                return this.DivisionField;
            }
            set {
                if ((object.ReferenceEquals(this.DivisionField, value) != true)) {
                    this.DivisionField = value;
                    this.RaisePropertyChanged("Division");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IndustryGroup {
            get {
                return this.IndustryGroupField;
            }
            set {
                if ((this.IndustryGroupField.Equals(value) != true)) {
                    this.IndustryGroupField = value;
                    this.RaisePropertyChanged("IndustryGroup");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MajorGroup {
            get {
                return this.MajorGroupField;
            }
            set {
                if ((this.MajorGroupField.Equals(value) != true)) {
                    this.MajorGroupField = value;
                    this.RaisePropertyChanged("MajorGroup");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SIC {
            get {
                return this.SICField;
            }
            set {
                if ((this.SICField.Equals(value) != true)) {
                    this.SICField = value;
                    this.RaisePropertyChanged("SIC");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Site", Namespace="http://schemas.datacontract.org/2004/07/ChcObjects")]
    [System.SerializableAttribute()]
    public partial class Site : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ActionDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactDetailsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DeletedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SICcodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SiteIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SiteNameField;
        
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
        public string ActionDetails {
            get {
                return this.ActionDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.ActionDetailsField, value) != true)) {
                    this.ActionDetailsField = value;
                    this.RaisePropertyChanged("ActionDetails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContactDetails {
            get {
                return this.ContactDetailsField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactDetailsField, value) != true)) {
                    this.ContactDetailsField = value;
                    this.RaisePropertyChanged("ContactDetails");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Deleted {
            get {
                return this.DeletedField;
            }
            set {
                if ((this.DeletedField.Equals(value) != true)) {
                    this.DeletedField = value;
                    this.RaisePropertyChanged("Deleted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SICcode {
            get {
                return this.SICcodeField;
            }
            set {
                if ((this.SICcodeField.Equals(value) != true)) {
                    this.SICcodeField = value;
                    this.RaisePropertyChanged("SICcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SiteID {
            get {
                return this.SiteIDField;
            }
            set {
                if ((this.SiteIDField.Equals(value) != true)) {
                    this.SiteIDField = value;
                    this.RaisePropertyChanged("SiteID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SiteName {
            get {
                return this.SiteNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SiteNameField, value) != true)) {
                    this.SiteNameField = value;
                    this.RaisePropertyChanged("SiteName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SiteService.ISiteService")]
    public interface ISiteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteService/GetSICLookups", ReplyAction="http://tempuri.org/ISiteService/GetSICLookupsResponse")]
        Chc.SiteService.SICLookup[] GetSICLookups();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteService/GetSICLookups", ReplyAction="http://tempuri.org/ISiteService/GetSICLookupsResponse")]
        System.Threading.Tasks.Task<Chc.SiteService.SICLookup[]> GetSICLookupsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteService/GetSICById", ReplyAction="http://tempuri.org/ISiteService/GetSICByIdResponse")]
        Chc.SiteService.SICLookup GetSICById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteService/GetSICById", ReplyAction="http://tempuri.org/ISiteService/GetSICByIdResponse")]
        System.Threading.Tasks.Task<Chc.SiteService.SICLookup> GetSICByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteService/GetSites", ReplyAction="http://tempuri.org/ISiteService/GetSitesResponse")]
        Chc.SiteService.Site[] GetSites();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteService/GetSites", ReplyAction="http://tempuri.org/ISiteService/GetSitesResponse")]
        System.Threading.Tasks.Task<Chc.SiteService.Site[]> GetSitesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteService/GetSiteById", ReplyAction="http://tempuri.org/ISiteService/GetSiteByIdResponse")]
        Chc.SiteService.Site GetSiteById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteService/GetSiteById", ReplyAction="http://tempuri.org/ISiteService/GetSiteByIdResponse")]
        System.Threading.Tasks.Task<Chc.SiteService.Site> GetSiteByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteService/CreateSite", ReplyAction="http://tempuri.org/ISiteService/CreateSiteResponse")]
        Chc.SiteService.Site CreateSite(Chc.SiteService.Site site);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteService/CreateSite", ReplyAction="http://tempuri.org/ISiteService/CreateSiteResponse")]
        System.Threading.Tasks.Task<Chc.SiteService.Site> CreateSiteAsync(Chc.SiteService.Site site);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteService/UpdateSite", ReplyAction="http://tempuri.org/ISiteService/UpdateSiteResponse")]
        Chc.SiteService.Site UpdateSite(Chc.SiteService.Site site);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteService/UpdateSite", ReplyAction="http://tempuri.org/ISiteService/UpdateSiteResponse")]
        System.Threading.Tasks.Task<Chc.SiteService.Site> UpdateSiteAsync(Chc.SiteService.Site site);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISiteServiceChannel : Chc.SiteService.ISiteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SiteServiceClient : System.ServiceModel.ClientBase<Chc.SiteService.ISiteService>, Chc.SiteService.ISiteService {
        
        public SiteServiceClient() {
        }
        
        public SiteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SiteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SiteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SiteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Chc.SiteService.SICLookup[] GetSICLookups() {
            return base.Channel.GetSICLookups();
        }
        
        public System.Threading.Tasks.Task<Chc.SiteService.SICLookup[]> GetSICLookupsAsync() {
            return base.Channel.GetSICLookupsAsync();
        }
        
        public Chc.SiteService.SICLookup GetSICById(int id) {
            return base.Channel.GetSICById(id);
        }
        
        public System.Threading.Tasks.Task<Chc.SiteService.SICLookup> GetSICByIdAsync(int id) {
            return base.Channel.GetSICByIdAsync(id);
        }
        
        public Chc.SiteService.Site[] GetSites() {
            return base.Channel.GetSites();
        }
        
        public System.Threading.Tasks.Task<Chc.SiteService.Site[]> GetSitesAsync() {
            return base.Channel.GetSitesAsync();
        }
        
        public Chc.SiteService.Site GetSiteById(int id) {
            return base.Channel.GetSiteById(id);
        }
        
        public System.Threading.Tasks.Task<Chc.SiteService.Site> GetSiteByIdAsync(int id) {
            return base.Channel.GetSiteByIdAsync(id);
        }
        
        public Chc.SiteService.Site CreateSite(Chc.SiteService.Site site) {
            return base.Channel.CreateSite(site);
        }
        
        public System.Threading.Tasks.Task<Chc.SiteService.Site> CreateSiteAsync(Chc.SiteService.Site site) {
            return base.Channel.CreateSiteAsync(site);
        }
        
        public Chc.SiteService.Site UpdateSite(Chc.SiteService.Site site) {
            return base.Channel.UpdateSite(site);
        }
        
        public System.Threading.Tasks.Task<Chc.SiteService.Site> UpdateSiteAsync(Chc.SiteService.Site site) {
            return base.Channel.UpdateSiteAsync(site);
        }
    }
}
