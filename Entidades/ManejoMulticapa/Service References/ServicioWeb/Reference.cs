﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManejoMulticapa.ServicioWeb {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ManejoMulticapa.ServicioWeb.Alquiler> AlquileresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
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
        public System.Collections.Generic.List<ManejoMulticapa.ServicioWeb.Alquiler> Alquileres {
            get {
                return this.AlquileresField;
            }
            set {
                if ((object.ReferenceEquals(this.AlquileresField, value) != true)) {
                    this.AlquileresField = value;
                    this.RaisePropertyChanged("Alquileres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellidos {
            get {
                return this.ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosField, value) != true)) {
                    this.ApellidosField = value;
                    this.RaisePropertyChanged("Apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdCliente {
            get {
                return this.IdClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.IdClienteField, value) != true)) {
                    this.IdClienteField = value;
                    this.RaisePropertyChanged("IdCliente");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Alquiler", Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    [System.SerializableAttribute()]
    public partial class Alquiler : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaDevolucionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaEntregaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdAlquilerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdCocheField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdTiendaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TiendaDevolucionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TiendaEntregaField;
        
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
        public System.DateTime FechaDevolucion {
            get {
                return this.FechaDevolucionField;
            }
            set {
                if ((this.FechaDevolucionField.Equals(value) != true)) {
                    this.FechaDevolucionField = value;
                    this.RaisePropertyChanged("FechaDevolucion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaEntrega {
            get {
                return this.FechaEntregaField;
            }
            set {
                if ((this.FechaEntregaField.Equals(value) != true)) {
                    this.FechaEntregaField = value;
                    this.RaisePropertyChanged("FechaEntrega");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdAlquiler {
            get {
                return this.IdAlquilerField;
            }
            set {
                if ((this.IdAlquilerField.Equals(value) != true)) {
                    this.IdAlquilerField = value;
                    this.RaisePropertyChanged("IdAlquiler");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdCliente {
            get {
                return this.IdClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.IdClienteField, value) != true)) {
                    this.IdClienteField = value;
                    this.RaisePropertyChanged("IdCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdCoche {
            get {
                return this.IdCocheField;
            }
            set {
                if ((object.ReferenceEquals(this.IdCocheField, value) != true)) {
                    this.IdCocheField = value;
                    this.RaisePropertyChanged("IdCoche");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdTienda {
            get {
                return this.IdTiendaField;
            }
            set {
                if ((this.IdTiendaField.Equals(value) != true)) {
                    this.IdTiendaField = value;
                    this.RaisePropertyChanged("IdTienda");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TiendaDevolucion {
            get {
                return this.TiendaDevolucionField;
            }
            set {
                if ((this.TiendaDevolucionField.Equals(value) != true)) {
                    this.TiendaDevolucionField = value;
                    this.RaisePropertyChanged("TiendaDevolucion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TiendaEntrega {
            get {
                return this.TiendaEntregaField;
            }
            set {
                if ((this.TiendaEntregaField.Equals(value) != true)) {
                    this.TiendaEntregaField = value;
                    this.RaisePropertyChanged("TiendaEntrega");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Coche", Namespace="http://schemas.datacontract.org/2004/07/Entidades")]
    [System.SerializableAttribute()]
    public partial class Coche : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short CombustibleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ConsumoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdCocheField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KilometrajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MarcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModeloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UbicacionField;
        
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
        public int Categoria {
            get {
                return this.CategoriaField;
            }
            set {
                if ((this.CategoriaField.Equals(value) != true)) {
                    this.CategoriaField = value;
                    this.RaisePropertyChanged("Categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Combustible {
            get {
                return this.CombustibleField;
            }
            set {
                if ((this.CombustibleField.Equals(value) != true)) {
                    this.CombustibleField = value;
                    this.RaisePropertyChanged("Combustible");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Consumo {
            get {
                return this.ConsumoField;
            }
            set {
                if ((this.ConsumoField.Equals(value) != true)) {
                    this.ConsumoField = value;
                    this.RaisePropertyChanged("Consumo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdCoche {
            get {
                return this.IdCocheField;
            }
            set {
                if ((object.ReferenceEquals(this.IdCocheField, value) != true)) {
                    this.IdCocheField = value;
                    this.RaisePropertyChanged("IdCoche");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Kilometraje {
            get {
                return this.KilometrajeField;
            }
            set {
                if ((this.KilometrajeField.Equals(value) != true)) {
                    this.KilometrajeField = value;
                    this.RaisePropertyChanged("Kilometraje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Marca {
            get {
                return this.MarcaField;
            }
            set {
                if ((object.ReferenceEquals(this.MarcaField, value) != true)) {
                    this.MarcaField = value;
                    this.RaisePropertyChanged("Marca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modelo {
            get {
                return this.ModeloField;
            }
            set {
                if ((object.ReferenceEquals(this.ModeloField, value) != true)) {
                    this.ModeloField = value;
                    this.RaisePropertyChanged("Modelo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Ubicacion {
            get {
                return this.UbicacionField;
            }
            set {
                if ((this.UbicacionField.Equals(value) != true)) {
                    this.UbicacionField = value;
                    this.RaisePropertyChanged("Ubicacion");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioWeb.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClientes", ReplyAction="http://tempuri.org/IService1/GetClientesResponse")]
        System.Collections.Generic.List<ManejoMulticapa.ServicioWeb.Cliente> GetClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClientes", ReplyAction="http://tempuri.org/IService1/GetClientesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ManejoMulticapa.ServicioWeb.Cliente>> GetClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClienteById", ReplyAction="http://tempuri.org/IService1/GetClienteByIdResponse")]
        ManejoMulticapa.ServicioWeb.Cliente GetClienteById(string idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClienteById", ReplyAction="http://tempuri.org/IService1/GetClienteByIdResponse")]
        System.Threading.Tasks.Task<ManejoMulticapa.ServicioWeb.Cliente> GetClienteByIdAsync(string idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrdersByIdCliente", ReplyAction="http://tempuri.org/IService1/GetOrdersByIdClienteResponse")]
        System.Collections.Generic.List<ManejoMulticapa.ServicioWeb.Alquiler> GetOrdersByIdCliente(string idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrdersByIdCliente", ReplyAction="http://tempuri.org/IService1/GetOrdersByIdClienteResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ManejoMulticapa.ServicioWeb.Alquiler>> GetOrdersByIdClienteAsync(string idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCarsByCategoryInStore", ReplyAction="http://tempuri.org/IService1/GetCarsByCategoryInStoreResponse")]
        System.Collections.Generic.List<ManejoMulticapa.ServicioWeb.Coche> GetCarsByCategoryInStore(int idCategoria, int idTienda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCarsByCategoryInStore", ReplyAction="http://tempuri.org/IService1/GetCarsByCategoryInStoreResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ManejoMulticapa.ServicioWeb.Coche>> GetCarsByCategoryInStoreAsync(int idCategoria, int idTienda);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ManejoMulticapa.ServicioWeb.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ManejoMulticapa.ServicioWeb.IService1>, ManejoMulticapa.ServicioWeb.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public System.Collections.Generic.List<ManejoMulticapa.ServicioWeb.Cliente> GetClientes() {
            return base.Channel.GetClientes();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ManejoMulticapa.ServicioWeb.Cliente>> GetClientesAsync() {
            return base.Channel.GetClientesAsync();
        }
        
        public ManejoMulticapa.ServicioWeb.Cliente GetClienteById(string idCliente) {
            return base.Channel.GetClienteById(idCliente);
        }
        
        public System.Threading.Tasks.Task<ManejoMulticapa.ServicioWeb.Cliente> GetClienteByIdAsync(string idCliente) {
            return base.Channel.GetClienteByIdAsync(idCliente);
        }
        
        public System.Collections.Generic.List<ManejoMulticapa.ServicioWeb.Alquiler> GetOrdersByIdCliente(string idCliente) {
            return base.Channel.GetOrdersByIdCliente(idCliente);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ManejoMulticapa.ServicioWeb.Alquiler>> GetOrdersByIdClienteAsync(string idCliente) {
            return base.Channel.GetOrdersByIdClienteAsync(idCliente);
        }
        
        public System.Collections.Generic.List<ManejoMulticapa.ServicioWeb.Coche> GetCarsByCategoryInStore(int idCategoria, int idTienda) {
            return base.Channel.GetCarsByCategoryInStore(idCategoria, idTienda);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ManejoMulticapa.ServicioWeb.Coche>> GetCarsByCategoryInStoreAsync(int idCategoria, int idTienda) {
            return base.Channel.GetCarsByCategoryInStoreAsync(idCategoria, idTienda);
        }
    }
}