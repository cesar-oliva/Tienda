﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceImpuesto
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoImpuesto", Namespace="http://schemas.datacontract.org/2004/07/CapaServicioServidor")]
    public partial class DtoImpuesto : object
    {
        
        private double AlicuotaField;
        
        private string DescripcionField;
        
        private System.DateTime FechaRegistroField;
        
        private int IdImpuestoField;
        
        private ServiceImpuesto.Estado OEstadoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Alicuota
        {
            get
            {
                return this.AlicuotaField;
            }
            set
            {
                this.AlicuotaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion
        {
            get
            {
                return this.DescripcionField;
            }
            set
            {
                this.DescripcionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaRegistro
        {
            get
            {
                return this.FechaRegistroField;
            }
            set
            {
                this.FechaRegistroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdImpuesto
        {
            get
            {
                return this.IdImpuestoField;
            }
            set
            {
                this.IdImpuestoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceImpuesto.Estado OEstado
        {
            get
            {
                return this.OEstadoField;
            }
            set
            {
                this.OEstadoField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Estado", Namespace="http://schemas.datacontract.org/2004/07/CapaNegocio")]
    public enum Estado : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Activo = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inactivo = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceImpuesto.IServiceImpuesto")]
    public interface IServiceImpuesto
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImpuesto/IngresarImpuesto", ReplyAction="http://tempuri.org/IServiceImpuesto/IngresarImpuestoResponse")]
        bool IngresarImpuesto(ServiceImpuesto.DtoImpuesto oImpuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImpuesto/IngresarImpuesto", ReplyAction="http://tempuri.org/IServiceImpuesto/IngresarImpuestoResponse")]
        System.Threading.Tasks.Task<bool> IngresarImpuestoAsync(ServiceImpuesto.DtoImpuesto oImpuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImpuesto/ModificarImpuesto", ReplyAction="http://tempuri.org/IServiceImpuesto/ModificarImpuestoResponse")]
        bool ModificarImpuesto(ServiceImpuesto.DtoImpuesto oImpuesto, int IdImpuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImpuesto/ModificarImpuesto", ReplyAction="http://tempuri.org/IServiceImpuesto/ModificarImpuestoResponse")]
        System.Threading.Tasks.Task<bool> ModificarImpuestoAsync(ServiceImpuesto.DtoImpuesto oImpuesto, int IdImpuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImpuesto/EliminarImpuesto", ReplyAction="http://tempuri.org/IServiceImpuesto/EliminarImpuestoResponse")]
        bool EliminarImpuesto(int IdImpuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImpuesto/EliminarImpuesto", ReplyAction="http://tempuri.org/IServiceImpuesto/EliminarImpuestoResponse")]
        System.Threading.Tasks.Task<bool> EliminarImpuestoAsync(int IdImpuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImpuesto/BuscarImpuestoById", ReplyAction="http://tempuri.org/IServiceImpuesto/BuscarImpuestoByIdResponse")]
        bool BuscarImpuestoById(int IdImpuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImpuesto/BuscarImpuestoById", ReplyAction="http://tempuri.org/IServiceImpuesto/BuscarImpuestoByIdResponse")]
        System.Threading.Tasks.Task<bool> BuscarImpuestoByIdAsync(int IdImpuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImpuesto/ListaImpuesto", ReplyAction="http://tempuri.org/IServiceImpuesto/ListaImpuestoResponse")]
        System.Collections.Generic.List<ServiceImpuesto.DtoImpuesto> ListaImpuesto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceImpuesto/ListaImpuesto", ReplyAction="http://tempuri.org/IServiceImpuesto/ListaImpuestoResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceImpuesto.DtoImpuesto>> ListaImpuestoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IServiceImpuestoChannel : ServiceImpuesto.IServiceImpuesto, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class ServiceImpuestoClient : System.ServiceModel.ClientBase<ServiceImpuesto.IServiceImpuesto>, ServiceImpuesto.IServiceImpuesto
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceImpuestoClient() : 
                base(ServiceImpuestoClient.GetDefaultBinding(), ServiceImpuestoClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IServiceImpuesto.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceImpuestoClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceImpuestoClient.GetBindingForEndpoint(endpointConfiguration), ServiceImpuestoClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceImpuestoClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceImpuestoClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceImpuestoClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceImpuestoClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceImpuestoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public bool IngresarImpuesto(ServiceImpuesto.DtoImpuesto oImpuesto)
        {
            return base.Channel.IngresarImpuesto(oImpuesto);
        }
        
        public System.Threading.Tasks.Task<bool> IngresarImpuestoAsync(ServiceImpuesto.DtoImpuesto oImpuesto)
        {
            return base.Channel.IngresarImpuestoAsync(oImpuesto);
        }
        
        public bool ModificarImpuesto(ServiceImpuesto.DtoImpuesto oImpuesto, int IdImpuesto)
        {
            return base.Channel.ModificarImpuesto(oImpuesto, IdImpuesto);
        }
        
        public System.Threading.Tasks.Task<bool> ModificarImpuestoAsync(ServiceImpuesto.DtoImpuesto oImpuesto, int IdImpuesto)
        {
            return base.Channel.ModificarImpuestoAsync(oImpuesto, IdImpuesto);
        }
        
        public bool EliminarImpuesto(int IdImpuesto)
        {
            return base.Channel.EliminarImpuesto(IdImpuesto);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarImpuestoAsync(int IdImpuesto)
        {
            return base.Channel.EliminarImpuestoAsync(IdImpuesto);
        }
        
        public bool BuscarImpuestoById(int IdImpuesto)
        {
            return base.Channel.BuscarImpuestoById(IdImpuesto);
        }
        
        public System.Threading.Tasks.Task<bool> BuscarImpuestoByIdAsync(int IdImpuesto)
        {
            return base.Channel.BuscarImpuestoByIdAsync(IdImpuesto);
        }
        
        public System.Collections.Generic.List<ServiceImpuesto.DtoImpuesto> ListaImpuesto()
        {
            return base.Channel.ListaImpuesto();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceImpuesto.DtoImpuesto>> ListaImpuestoAsync()
        {
            return base.Channel.ListaImpuestoAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceImpuesto))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceImpuesto))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:10524/ServiceImpuesto.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceImpuestoClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IServiceImpuesto);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceImpuestoClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IServiceImpuesto);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IServiceImpuesto,
        }
    }
}
