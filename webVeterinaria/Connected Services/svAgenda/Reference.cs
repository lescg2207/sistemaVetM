﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webVeterinaria.svAgenda {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Evento", Namespace="http://schemas.datacontract.org/2004/07/wcfVeterinaria")]
    [System.SerializableAttribute()]
    public partial class Evento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaFinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaInicioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ObservacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TituloField;
        
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
        public string Cliente {
            get {
                return this.ClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.ClienteField, value) != true)) {
                    this.ClienteField = value;
                    this.RaisePropertyChanged("Cliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Color {
            get {
                return this.ColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorField, value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaFin {
            get {
                return this.FechaFinField;
            }
            set {
                if ((this.FechaFinField.Equals(value) != true)) {
                    this.FechaFinField = value;
                    this.RaisePropertyChanged("FechaFin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaInicio {
            get {
                return this.FechaInicioField;
            }
            set {
                if ((this.FechaInicioField.Equals(value) != true)) {
                    this.FechaInicioField = value;
                    this.RaisePropertyChanged("FechaInicio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Observacion {
            get {
                return this.ObservacionField;
            }
            set {
                if ((object.ReferenceEquals(this.ObservacionField, value) != true)) {
                    this.ObservacionField = value;
                    this.RaisePropertyChanged("Observacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titulo {
            get {
                return this.TituloField;
            }
            set {
                if ((object.ReferenceEquals(this.TituloField, value) != true)) {
                    this.TituloField = value;
                    this.RaisePropertyChanged("Titulo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Motivo", Namespace="http://schemas.datacontract.org/2004/07/wcfVeterinaria")]
    [System.SerializableAttribute()]
    public partial class Motivo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="svAgenda.IserviceAgenda")]
    public interface IserviceAgenda {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IserviceAgenda/ObtenerEventos", ReplyAction="http://tempuri.org/IserviceAgenda/ObtenerEventosResponse")]
        webVeterinaria.svAgenda.Evento[] ObtenerEventos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IserviceAgenda/ObtenerEventos", ReplyAction="http://tempuri.org/IserviceAgenda/ObtenerEventosResponse")]
        System.Threading.Tasks.Task<webVeterinaria.svAgenda.Evento[]> ObtenerEventosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IserviceAgenda/ListarMotivo", ReplyAction="http://tempuri.org/IserviceAgenda/ListarMotivoResponse")]
        webVeterinaria.svAgenda.Motivo[] ListarMotivo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IserviceAgenda/ListarMotivo", ReplyAction="http://tempuri.org/IserviceAgenda/ListarMotivoResponse")]
        System.Threading.Tasks.Task<webVeterinaria.svAgenda.Motivo[]> ListarMotivoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IserviceAgendaChannel : webVeterinaria.svAgenda.IserviceAgenda, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IserviceAgendaClient : System.ServiceModel.ClientBase<webVeterinaria.svAgenda.IserviceAgenda>, webVeterinaria.svAgenda.IserviceAgenda {
        
        public IserviceAgendaClient() {
        }
        
        public IserviceAgendaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IserviceAgendaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IserviceAgendaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IserviceAgendaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public webVeterinaria.svAgenda.Evento[] ObtenerEventos() {
            return base.Channel.ObtenerEventos();
        }
        
        public System.Threading.Tasks.Task<webVeterinaria.svAgenda.Evento[]> ObtenerEventosAsync() {
            return base.Channel.ObtenerEventosAsync();
        }
        
        public webVeterinaria.svAgenda.Motivo[] ListarMotivo() {
            return base.Channel.ListarMotivo();
        }
        
        public System.Threading.Tasks.Task<webVeterinaria.svAgenda.Motivo[]> ListarMotivoAsync() {
            return base.Channel.ListarMotivoAsync();
        }
    }
}
