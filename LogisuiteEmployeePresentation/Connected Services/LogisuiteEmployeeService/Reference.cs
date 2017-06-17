﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogisuiteEmployeePresentation.LogisuiteEmployeeService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://logisuite/employees/")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        private System.DateTime DateofBirthField;
        
        private decimal AnnualSalaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        private long PhoneField;
        
        private long SocialSecurityNumberField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.DateTime DateofBirth {
            get {
                return this.DateofBirthField;
            }
            set {
                if ((this.DateofBirthField.Equals(value) != true)) {
                    this.DateofBirthField = value;
                    this.RaisePropertyChanged("DateofBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public decimal AnnualSalary {
            get {
                return this.AnnualSalaryField;
            }
            set {
                if ((this.AnnualSalaryField.Equals(value) != true)) {
                    this.AnnualSalaryField = value;
                    this.RaisePropertyChanged("AnnualSalary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public long Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((this.PhoneField.Equals(value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public long SocialSecurityNumber {
            get {
                return this.SocialSecurityNumberField;
            }
            set {
                if ((this.SocialSecurityNumberField.Equals(value) != true)) {
                    this.SocialSecurityNumberField = value;
                    this.RaisePropertyChanged("SocialSecurityNumber");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://logisuite/employees/", ConfigurationName="LogisuiteEmployeeService.EmployeesServiceSoap")]
    public interface EmployeesServiceSoap {
        
        // CODEGEN: Generating message contract since element name ViewAllResult from namespace http://logisuite/employees/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://logisuite/employees/ViewAll", ReplyAction="*")]
        LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllResponse ViewAll(LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://logisuite/employees/ViewAll", ReplyAction="*")]
        System.Threading.Tasks.Task<LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllResponse> ViewAllAsync(LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllRequest request);
        
        // CODEGEN: Generating message contract since element name value from namespace http://logisuite/employees/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://logisuite/employees/Save", ReplyAction="*")]
        LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveResponse Save(LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://logisuite/employees/Save", ReplyAction="*")]
        System.Threading.Tasks.Task<LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveResponse> SaveAsync(LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://logisuite/employees/Delete", ReplyAction="*")]
        int Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://logisuite/employees/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<int> DeleteAsync(int id);
        
        // CODEGEN: Generating message contract since element name SelectResult from namespace http://logisuite/employees/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://logisuite/employees/Select", ReplyAction="*")]
        LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectResponse Select(LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://logisuite/employees/Select", ReplyAction="*")]
        System.Threading.Tasks.Task<LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectResponse> SelectAsync(LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ViewAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ViewAll", Namespace="http://logisuite/employees/", Order=0)]
        public LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllRequestBody Body;
        
        public ViewAllRequest() {
        }
        
        public ViewAllRequest(LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ViewAllRequestBody {
        
        public ViewAllRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ViewAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ViewAllResponse", Namespace="http://logisuite/employees/", Order=0)]
        public LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllResponseBody Body;
        
        public ViewAllResponse() {
        }
        
        public ViewAllResponse(LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://logisuite/employees/")]
    public partial class ViewAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public LogisuiteEmployeePresentation.LogisuiteEmployeeService.Employee[] ViewAllResult;
        
        public ViewAllResponseBody() {
        }
        
        public ViewAllResponseBody(LogisuiteEmployeePresentation.LogisuiteEmployeeService.Employee[] ViewAllResult) {
            this.ViewAllResult = ViewAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Save", Namespace="http://logisuite/employees/", Order=0)]
        public LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveRequestBody Body;
        
        public SaveRequest() {
        }
        
        public SaveRequest(LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://logisuite/employees/")]
    public partial class SaveRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public LogisuiteEmployeePresentation.LogisuiteEmployeeService.Employee value;
        
        public SaveRequestBody() {
        }
        
        public SaveRequestBody(LogisuiteEmployeePresentation.LogisuiteEmployeeService.Employee value) {
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveResponse", Namespace="http://logisuite/employees/", Order=0)]
        public LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveResponseBody Body;
        
        public SaveResponse() {
        }
        
        public SaveResponse(LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class SaveResponseBody {
        
        public SaveResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelectRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Select", Namespace="http://logisuite/employees/", Order=0)]
        public LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectRequestBody Body;
        
        public SelectRequest() {
        }
        
        public SelectRequest(LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://logisuite/employees/")]
    public partial class SelectRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public SelectRequestBody() {
        }
        
        public SelectRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelectResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelectResponse", Namespace="http://logisuite/employees/", Order=0)]
        public LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectResponseBody Body;
        
        public SelectResponse() {
        }
        
        public SelectResponse(LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://logisuite/employees/")]
    public partial class SelectResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public LogisuiteEmployeePresentation.LogisuiteEmployeeService.Employee SelectResult;
        
        public SelectResponseBody() {
        }
        
        public SelectResponseBody(LogisuiteEmployeePresentation.LogisuiteEmployeeService.Employee SelectResult) {
            this.SelectResult = SelectResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EmployeesServiceSoapChannel : LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeesServiceSoapClient : System.ServiceModel.ClientBase<LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap>, LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap {
        
        public EmployeesServiceSoapClient() {
        }
        
        public EmployeesServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeesServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeesServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeesServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllResponse LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap.ViewAll(LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllRequest request) {
            return base.Channel.ViewAll(request);
        }
        
        public LogisuiteEmployeePresentation.LogisuiteEmployeeService.Employee[] ViewAll() {
            LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllRequest inValue = new LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllRequest();
            inValue.Body = new LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllRequestBody();
            LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllResponse retVal = ((LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap)(this)).ViewAll(inValue);
            return retVal.Body.ViewAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllResponse> LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap.ViewAllAsync(LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllRequest request) {
            return base.Channel.ViewAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllResponse> ViewAllAsync() {
            LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllRequest inValue = new LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllRequest();
            inValue.Body = new LogisuiteEmployeePresentation.LogisuiteEmployeeService.ViewAllRequestBody();
            return ((LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap)(this)).ViewAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveResponse LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap.Save(LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveRequest request) {
            return base.Channel.Save(request);
        }
        
        public void Save(LogisuiteEmployeePresentation.LogisuiteEmployeeService.Employee value) {
            LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveRequest inValue = new LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveRequest();
            inValue.Body = new LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveRequestBody();
            inValue.Body.value = value;
            LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveResponse retVal = ((LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap)(this)).Save(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveResponse> LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap.SaveAsync(LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveRequest request) {
            return base.Channel.SaveAsync(request);
        }
        
        public System.Threading.Tasks.Task<LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveResponse> SaveAsync(LogisuiteEmployeePresentation.LogisuiteEmployeeService.Employee value) {
            LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveRequest inValue = new LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveRequest();
            inValue.Body = new LogisuiteEmployeePresentation.LogisuiteEmployeeService.SaveRequestBody();
            inValue.Body.value = value;
            return ((LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap)(this)).SaveAsync(inValue);
        }
        
        public int Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<int> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectResponse LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap.Select(LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectRequest request) {
            return base.Channel.Select(request);
        }
        
        public LogisuiteEmployeePresentation.LogisuiteEmployeeService.Employee Select(int id) {
            LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectRequest inValue = new LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectRequest();
            inValue.Body = new LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectRequestBody();
            inValue.Body.id = id;
            LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectResponse retVal = ((LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap)(this)).Select(inValue);
            return retVal.Body.SelectResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectResponse> LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap.SelectAsync(LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectRequest request) {
            return base.Channel.SelectAsync(request);
        }
        
        public System.Threading.Tasks.Task<LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectResponse> SelectAsync(int id) {
            LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectRequest inValue = new LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectRequest();
            inValue.Body = new LogisuiteEmployeePresentation.LogisuiteEmployeeService.SelectRequestBody();
            inValue.Body.id = id;
            return ((LogisuiteEmployeePresentation.LogisuiteEmployeeService.EmployeesServiceSoap)(this)).SelectAsync(inValue);
        }
    }
}
