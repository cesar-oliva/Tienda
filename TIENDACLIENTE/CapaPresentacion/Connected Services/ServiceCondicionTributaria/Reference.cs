﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceCondicionTributaria
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoCondicionTributaria", Namespace="http://schemas.datacontract.org/2004/07/CapaServicioServidor")]
    public partial class DtoCondicionTributaria : object
    {
        
        private string CodigoCondicionTributariaField;
        
        private string DescripcionCondicionTributariaField;
        
        private System.DateTime FechaRegistroField;
        
        private int IdCondicionTributariaField;
        
        private ServiceCondicionTributaria.Estado OEstadoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoCondicionTributaria
        {
            get
            {
                return this.CodigoCondicionTributariaField;
            }
            set
            {
                this.CodigoCondicionTributariaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescripcionCondicionTributaria
        {
            get
            {
                return this.DescripcionCondicionTributariaField;
            }
            set
            {
                this.DescripcionCondicionTributariaField = value;
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
        public int IdCondicionTributaria
        {
            get
            {
                return this.IdCondicionTributariaField;
            }
            set
            {
                this.IdCondicionTributariaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceCondicionTributaria.Estado OEstado
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CondicionTributaria", Namespace="http://schemas.datacontract.org/2004/07/CapaNegocio")]
    public partial class CondicionTributaria : object
    {
        
        private string CodigoCondicionTributariaField;
        
        private string DescripcionCondicionTributariaField;
        
        private System.DateTime FechaRegistroField;
        
        private int IdCondicionTributariaField;
        
        private ServiceCondicionTributaria.Estado OEstadoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoCondicionTributaria
        {
            get
            {
                return this.CodigoCondicionTributariaField;
            }
            set
            {
                this.CodigoCondicionTributariaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescripcionCondicionTributaria
        {
            get
            {
                return this.DescripcionCondicionTributariaField;
            }
            set
            {
                this.DescripcionCondicionTributariaField = value;
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
        public int IdCondicionTributaria
        {
            get
            {
                return this.IdCondicionTributariaField;
            }
            set
            {
                this.IdCondicionTributariaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceCondicionTributaria.Estado OEstado
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCondicionTributaria.IServiceCondicionTributaria")]
    public interface IServiceCondicionTributaria
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCondicionTributaria/AgregarCondicionTributaria", ReplyAction="http://tempuri.org/IServiceCondicionTributaria/AgregarCondicionTributariaResponse" +
            "")]
        bool AgregarCondicionTributaria(ServiceCondicionTributaria.DtoCondicionTributaria oCondicionTributaria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCondicionTributaria/AgregarCondicionTributaria", ReplyAction="http://tempuri.org/IServiceCondicionTributaria/AgregarCondicionTributariaResponse" +
            "")]
        System.Threading.Tasks.Task<bool> AgregarCondicionTributariaAsync(ServiceCondicionTributaria.DtoCondicionTributaria oCondicionTributaria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCondicionTributaria/ModificarCondicionTributaria", ReplyAction="http://tempuri.org/IServiceCondicionTributaria/ModificarCondicionTributariaRespon" +
            "se")]
        bool ModificarCondicionTributaria(ServiceCondicionTributaria.DtoCondicionTributaria oCondicionTributaria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCondicionTributaria/ModificarCondicionTributaria", ReplyAction="http://tempuri.org/IServiceCondicionTributaria/ModificarCondicionTributariaRespon" +
            "se")]
        System.Threading.Tasks.Task<bool> ModificarCondicionTributariaAsync(ServiceCondicionTributaria.DtoCondicionTributaria oCondicionTributaria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCondicionTributaria/EliminarCondicionTributaria", ReplyAction="http://tempuri.org/IServiceCondicionTributaria/EliminarCondicionTributariaRespons" +
            "e")]
        bool EliminarCondicionTributaria(int IdCondicionTributaria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCondicionTributaria/EliminarCondicionTributaria", ReplyAction="http://tempuri.org/IServiceCondicionTributaria/EliminarCondicionTributariaRespons" +
            "e")]
        System.Threading.Tasks.Task<bool> EliminarCondicionTributariaAsync(int IdCondicionTributaria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCondicionTributaria/ListaCondicionTributaria", ReplyAction="http://tempuri.org/IServiceCondicionTributaria/ListaCondicionTributariaResponse")]
        ServiceCondicionTributaria.DtoCondicionTributaria[] ListaCondicionTributaria();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCondicionTributaria/ListaCondicionTributaria", ReplyAction="http://tempuri.org/IServiceCondicionTributaria/ListaCondicionTributariaResponse")]
        System.Threading.Tasks.Task<ServiceCondicionTributaria.DtoCondicionTributaria[]> ListaCondicionTributariaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCondicionTributaria/ObtenerCondicionTributariaByDescri" +
            "pcion", ReplyAction="http://tempuri.org/IServiceCondicionTributaria/ObtenerCondicionTributariaByDescri" +
            "pcionResponse")]
        ServiceCondicionTributaria.CondicionTributaria ObtenerCondicionTributariaByDescripcion(string oCondicionTributaria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCondicionTributaria/ObtenerCondicionTributariaByDescri" +
            "pcion", ReplyAction="http://tempuri.org/IServiceCondicionTributaria/ObtenerCondicionTributariaByDescri" +
            "pcionResponse")]
        System.Threading.Tasks.Task<ServiceCondicionTributaria.CondicionTributaria> ObtenerCondicionTributariaByDescripcionAsync(string oCondicionTributaria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCondicionTributaria/ObtenerCondicionTributariaById", ReplyAction="http://tempuri.org/IServiceCondicionTributaria/ObtenerCondicionTributariaByIdResp" +
            "onse")]
        ServiceCondicionTributaria.CondicionTributaria ObtenerCondicionTributariaById(int oCondicionTributaria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCondicionTributaria/ObtenerCondicionTributariaById", ReplyAction="http://tempuri.org/IServiceCondicionTributaria/ObtenerCondicionTributariaByIdResp" +
            "onse")]
        System.Threading.Tasks.Task<ServiceCondicionTributaria.CondicionTributaria> ObtenerCondicionTributariaByIdAsync(int oCondicionTributaria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCondicionTributaria/ObtenerEstadoByDescripcion", ReplyAction="http://tempuri.org/IServiceCondicionTributaria/ObtenerEstadoByDescripcionResponse" +
            "")]
        ServiceCondicionTributaria.Estado ObtenerEstadoByDescripcion(string oEstado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCondicionTributaria/ObtenerEstadoByDescripcion", ReplyAction="http://tempuri.org/IServiceCondicionTributaria/ObtenerEstadoByDescripcionResponse" +
            "")]
        System.Threading.Tasks.Task<ServiceCondicionTributaria.Estado> ObtenerEstadoByDescripcionAsync(string oEstado);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IServiceCondicionTributariaChannel : ServiceCondicionTributaria.IServiceCondicionTributaria, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class ServiceCondicionTributariaClient : System.ServiceModel.ClientBase<ServiceCondicionTributaria.IServiceCondicionTributaria>, ServiceCondicionTributaria.IServiceCondicionTributaria
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceCondicionTributariaClient() : 
                base(ServiceCondicionTributariaClient.GetDefaultBinding(), ServiceCondicionTributariaClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IServiceCondicionTributaria.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceCondicionTributariaClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceCondicionTributariaClient.GetBindingForEndpoint(endpointConfiguration), ServiceCondicionTributariaClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceCondicionTributariaClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceCondicionTributariaClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceCondicionTributariaClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceCondicionTributariaClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceCondicionTributariaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public bool AgregarCondicionTributaria(ServiceCondicionTributaria.DtoCondicionTributaria oCondicionTributaria)
        {
            return base.Channel.AgregarCondicionTributaria(oCondicionTributaria);
        }
        
        public System.Threading.Tasks.Task<bool> AgregarCondicionTributariaAsync(ServiceCondicionTributaria.DtoCondicionTributaria oCondicionTributaria)
        {
            return base.Channel.AgregarCondicionTributariaAsync(oCondicionTributaria);
        }
        
        public bool ModificarCondicionTributaria(ServiceCondicionTributaria.DtoCondicionTributaria oCondicionTributaria)
        {
            return base.Channel.ModificarCondicionTributaria(oCondicionTributaria);
        }
        
        public System.Threading.Tasks.Task<bool> ModificarCondicionTributariaAsync(ServiceCondicionTributaria.DtoCondicionTributaria oCondicionTributaria)
        {
            return base.Channel.ModificarCondicionTributariaAsync(oCondicionTributaria);
        }
        
        public bool EliminarCondicionTributaria(int IdCondicionTributaria)
        {
            return base.Channel.EliminarCondicionTributaria(IdCondicionTributaria);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarCondicionTributariaAsync(int IdCondicionTributaria)
        {
            return base.Channel.EliminarCondicionTributariaAsync(IdCondicionTributaria);
        }
        
        public ServiceCondicionTributaria.DtoCondicionTributaria[] ListaCondicionTributaria()
        {
            return base.Channel.ListaCondicionTributaria();
        }
        
        public System.Threading.Tasks.Task<ServiceCondicionTributaria.DtoCondicionTributaria[]> ListaCondicionTributariaAsync()
        {
            return base.Channel.ListaCondicionTributariaAsync();
        }
        
        public ServiceCondicionTributaria.CondicionTributaria ObtenerCondicionTributariaByDescripcion(string oCondicionTributaria)
        {
            return base.Channel.ObtenerCondicionTributariaByDescripcion(oCondicionTributaria);
        }
        
        public System.Threading.Tasks.Task<ServiceCondicionTributaria.CondicionTributaria> ObtenerCondicionTributariaByDescripcionAsync(string oCondicionTributaria)
        {
            return base.Channel.ObtenerCondicionTributariaByDescripcionAsync(oCondicionTributaria);
        }
        
        public ServiceCondicionTributaria.CondicionTributaria ObtenerCondicionTributariaById(int oCondicionTributaria)
        {
            return base.Channel.ObtenerCondicionTributariaById(oCondicionTributaria);
        }
        
        public System.Threading.Tasks.Task<ServiceCondicionTributaria.CondicionTributaria> ObtenerCondicionTributariaByIdAsync(int oCondicionTributaria)
        {
            return base.Channel.ObtenerCondicionTributariaByIdAsync(oCondicionTributaria);
        }
        
        public ServiceCondicionTributaria.Estado ObtenerEstadoByDescripcion(string oEstado)
        {
            return base.Channel.ObtenerEstadoByDescripcion(oEstado);
        }
        
        public System.Threading.Tasks.Task<ServiceCondicionTributaria.Estado> ObtenerEstadoByDescripcionAsync(string oEstado)
        {
            return base.Channel.ObtenerEstadoByDescripcionAsync(oEstado);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceCondicionTributaria))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceCondicionTributaria))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:10524/ServiceCondicionTributaria.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceCondicionTributariaClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IServiceCondicionTributaria);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceCondicionTributariaClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IServiceCondicionTributaria);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IServiceCondicionTributaria,
        }
    }
}
