﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18449
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_CIF.Proxies.Usuario {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UsuarioDTO", Namespace="http://schemas.datacontract.org/2004/07/SistemaCIF_Service.DTOS.ModuloComunesCIF")]
    [System.SerializableAttribute()]
    public partial class UsuarioDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ConfirmacionContraseñaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContraseñaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaNacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioIdField;
        
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
        public string Apellido {
            get {
                return this.ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoField, value) != true)) {
                    this.ApellidoField = value;
                    this.RaisePropertyChanged("Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ConfirmacionContraseña {
            get {
                return this.ConfirmacionContraseñaField;
            }
            set {
                if ((object.ReferenceEquals(this.ConfirmacionContraseñaField, value) != true)) {
                    this.ConfirmacionContraseñaField = value;
                    this.RaisePropertyChanged("ConfirmacionContraseña");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contraseña {
            get {
                return this.ContraseñaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContraseñaField, value) != true)) {
                    this.ContraseñaField = value;
                    this.RaisePropertyChanged("Contraseña");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaNacimiento {
            get {
                return this.FechaNacimientoField;
            }
            set {
                if ((this.FechaNacimientoField.Equals(value) != true)) {
                    this.FechaNacimientoField = value;
                    this.RaisePropertyChanged("FechaNacimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UsuarioId {
            get {
                return this.UsuarioIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioIdField, value) != true)) {
                    this.UsuarioIdField = value;
                    this.RaisePropertyChanged("UsuarioId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Proxies.Usuario.IUsuarioService")]
    public interface IUsuarioService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/DoWork", ReplyAction="http://tempuri.org/IUsuarioService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/DoWork", ReplyAction="http://tempuri.org/IUsuarioService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ObtenerUsuario", ReplyAction="http://tempuri.org/IUsuarioService/ObtenerUsuarioResponse")]
        Sistema_CIF.Proxies.Usuario.UsuarioDTO[] ObtenerUsuario();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/ObtenerUsuario", ReplyAction="http://tempuri.org/IUsuarioService/ObtenerUsuarioResponse")]
        System.Threading.Tasks.Task<Sistema_CIF.Proxies.Usuario.UsuarioDTO[]> ObtenerUsuarioAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/CrearUsuario", ReplyAction="http://tempuri.org/IUsuarioService/CrearUsuarioResponse")]
        void CrearUsuario(Sistema_CIF.Proxies.Usuario.UsuarioDTO usuarioDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/CrearUsuario", ReplyAction="http://tempuri.org/IUsuarioService/CrearUsuarioResponse")]
        System.Threading.Tasks.Task CrearUsuarioAsync(Sistema_CIF.Proxies.Usuario.UsuarioDTO usuarioDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/RemoverUsuarioo", ReplyAction="http://tempuri.org/IUsuarioService/RemoverUsuariooResponse")]
        void RemoverUsuarioo(Sistema_CIF.Proxies.Usuario.UsuarioDTO usuarioDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/RemoverUsuarioo", ReplyAction="http://tempuri.org/IUsuarioService/RemoverUsuariooResponse")]
        System.Threading.Tasks.Task RemoverUsuariooAsync(Sistema_CIF.Proxies.Usuario.UsuarioDTO usuarioDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/EditarUsuario", ReplyAction="http://tempuri.org/IUsuarioService/EditarUsuarioResponse")]
        void EditarUsuario(Sistema_CIF.Proxies.Usuario.UsuarioDTO usuarioDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/EditarUsuario", ReplyAction="http://tempuri.org/IUsuarioService/EditarUsuarioResponse")]
        System.Threading.Tasks.Task EditarUsuarioAsync(Sistema_CIF.Proxies.Usuario.UsuarioDTO usuarioDto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuarioServiceChannel : Sistema_CIF.Proxies.Usuario.IUsuarioService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioServiceClient : System.ServiceModel.ClientBase<Sistema_CIF.Proxies.Usuario.IUsuarioService>, Sistema_CIF.Proxies.Usuario.IUsuarioService {
        
        public UsuarioServiceClient() {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public Sistema_CIF.Proxies.Usuario.UsuarioDTO[] ObtenerUsuario() {
            return base.Channel.ObtenerUsuario();
        }
        
        public System.Threading.Tasks.Task<Sistema_CIF.Proxies.Usuario.UsuarioDTO[]> ObtenerUsuarioAsync() {
            return base.Channel.ObtenerUsuarioAsync();
        }
        
        public void CrearUsuario(Sistema_CIF.Proxies.Usuario.UsuarioDTO usuarioDto) {
            base.Channel.CrearUsuario(usuarioDto);
        }
        
        public System.Threading.Tasks.Task CrearUsuarioAsync(Sistema_CIF.Proxies.Usuario.UsuarioDTO usuarioDto) {
            return base.Channel.CrearUsuarioAsync(usuarioDto);
        }
        
        public void RemoverUsuarioo(Sistema_CIF.Proxies.Usuario.UsuarioDTO usuarioDto) {
            base.Channel.RemoverUsuarioo(usuarioDto);
        }
        
        public System.Threading.Tasks.Task RemoverUsuariooAsync(Sistema_CIF.Proxies.Usuario.UsuarioDTO usuarioDto) {
            return base.Channel.RemoverUsuariooAsync(usuarioDto);
        }
        
        public void EditarUsuario(Sistema_CIF.Proxies.Usuario.UsuarioDTO usuarioDto) {
            base.Channel.EditarUsuario(usuarioDto);
        }
        
        public System.Threading.Tasks.Task EditarUsuarioAsync(Sistema_CIF.Proxies.Usuario.UsuarioDTO usuarioDto) {
            return base.Channel.EditarUsuarioAsync(usuarioDto);
        }
    }
}
