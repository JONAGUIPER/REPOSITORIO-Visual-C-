﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Controladores.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClientes", ReplyAction="http://tempuri.org/IService1/GetClientesResponse")]
        System.Collections.Generic.List<Entidades.Cliente> GetClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClientes", ReplyAction="http://tempuri.org/IService1/GetClientesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Cliente>> GetClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClienteById", ReplyAction="http://tempuri.org/IService1/GetClienteByIdResponse")]
        Entidades.Cliente GetClienteById(string idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClienteById", ReplyAction="http://tempuri.org/IService1/GetClienteByIdResponse")]
        System.Threading.Tasks.Task<Entidades.Cliente> GetClienteByIdAsync(string idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrdersByIdCliente", ReplyAction="http://tempuri.org/IService1/GetOrdersByIdClienteResponse")]
        System.Collections.Generic.List<Entidades.Alquiler> GetOrdersByIdCliente(string idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOrdersByIdCliente", ReplyAction="http://tempuri.org/IService1/GetOrdersByIdClienteResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Alquiler>> GetOrdersByIdClienteAsync(string idCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCarsByCategoryInStore", ReplyAction="http://tempuri.org/IService1/GetCarsByCategoryInStoreResponse")]
        System.Collections.Generic.List<Entidades.Coche> GetCarsByCategoryInStore(int idCategoria, int idTienda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCarsByCategoryInStore", ReplyAction="http://tempuri.org/IService1/GetCarsByCategoryInStoreResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Coche>> GetCarsByCategoryInStoreAsync(int idCategoria, int idTienda);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Controladores.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Controladores.ServiceReference1.IService1>, Controladores.ServiceReference1.IService1 {
        
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
        
        public System.Collections.Generic.List<Entidades.Cliente> GetClientes() {
            return base.Channel.GetClientes();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Cliente>> GetClientesAsync() {
            return base.Channel.GetClientesAsync();
        }
        
        public Entidades.Cliente GetClienteById(string idCliente) {
            return base.Channel.GetClienteById(idCliente);
        }
        
        public System.Threading.Tasks.Task<Entidades.Cliente> GetClienteByIdAsync(string idCliente) {
            return base.Channel.GetClienteByIdAsync(idCliente);
        }
        
        public System.Collections.Generic.List<Entidades.Alquiler> GetOrdersByIdCliente(string idCliente) {
            return base.Channel.GetOrdersByIdCliente(idCliente);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Alquiler>> GetOrdersByIdClienteAsync(string idCliente) {
            return base.Channel.GetOrdersByIdClienteAsync(idCliente);
        }
        
        public System.Collections.Generic.List<Entidades.Coche> GetCarsByCategoryInStore(int idCategoria, int idTienda) {
            return base.Channel.GetCarsByCategoryInStore(idCategoria, idTienda);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Entidades.Coche>> GetCarsByCategoryInStoreAsync(int idCategoria, int idTienda) {
            return base.Channel.GetCarsByCategoryInStoreAsync(idCategoria, idTienda);
        }
    }
}
