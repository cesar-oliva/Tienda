﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceColor
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Color", Namespace="http://schemas.datacontract.org/2004/07/CapaNegocio")]
    public partial class Color : object
    {
        
        private string CodigoColorField;
        
        private string DescripcionColorField;
        
        private int IdColorField;
        
        private ServiceColor.Estado OEstadoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoColor
        {
            get
            {
                return this.CodigoColorField;
            }
            set
            {
                this.CodigoColorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescripcionColor
        {
            get
            {
                return this.DescripcionColorField;
            }
            set
            {
                this.DescripcionColorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdColor
        {
            get
            {
                return this.IdColorField;
            }
            set
            {
                this.IdColorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceColor.Estado OEstado
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoColor", Namespace="http://schemas.datacontract.org/2004/07/CapaServicioServidor")]
    public partial class DtoColor : object
    {
        
        private string CodigoColorField;
        
        private string DescripcionColorField;
        
        private int IdColorField;
        
        private ServiceColor.Estado OEstadoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoColor
        {
            get
            {
                return this.CodigoColorField;
            }
            set
            {
                this.CodigoColorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescripcionColor
        {
            get
            {
                return this.DescripcionColorField;
            }
            set
            {
                this.DescripcionColorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdColor
        {
            get
            {
                return this.IdColorField;
            }
            set
            {
                this.IdColorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceColor.Estado OEstado
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceColor.IServiceColor")]
    public interface IServiceColor
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceColor/AgregarColor", ReplyAction="http://tempuri.org/IServiceColor/AgregarColorResponse")]
        bool AgregarColor(ServiceColor.Color oColor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceColor/AgregarColor", ReplyAction="http://tempuri.org/IServiceColor/AgregarColorResponse")]
        System.Threading.Tasks.Task<bool> AgregarColorAsync(ServiceColor.Color oColor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceColor/ModificarColor", ReplyAction="http://tempuri.org/IServiceColor/ModificarColorResponse")]
        bool ModificarColor(ServiceColor.Color oColor, int IdColor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceColor/ModificarColor", ReplyAction="http://tempuri.org/IServiceColor/ModificarColorResponse")]
        System.Threading.Tasks.Task<bool> ModificarColorAsync(ServiceColor.Color oColor, int IdColor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceColor/EliminarColor", ReplyAction="http://tempuri.org/IServiceColor/EliminarColorResponse")]
        bool EliminarColor(int IdColor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceColor/EliminarColor", ReplyAction="http://tempuri.org/IServiceColor/EliminarColorResponse")]
        System.Threading.Tasks.Task<bool> EliminarColorAsync(int IdColor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceColor/ListaColor", ReplyAction="http://tempuri.org/IServiceColor/ListaColorResponse")]
        ServiceColor.DtoColor[] ListaColor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceColor/ListaColor", ReplyAction="http://tempuri.org/IServiceColor/ListaColorResponse")]
        System.Threading.Tasks.Task<ServiceColor.DtoColor[]> ListaColorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceColor/ObtenerColor", ReplyAction="http://tempuri.org/IServiceColor/ObtenerColorResponse")]
        ServiceColor.Color ObtenerColor(string Rubro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceColor/ObtenerColor", ReplyAction="http://tempuri.org/IServiceColor/ObtenerColorResponse")]
        System.Threading.Tasks.Task<ServiceColor.Color> ObtenerColorAsync(string Rubro);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IServiceColorChannel : ServiceColor.IServiceColor, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class ServiceColorClient : System.ServiceModel.ClientBase<ServiceColor.IServiceColor>, ServiceColor.IServiceColor
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceColorClient() : 
                base(ServiceColorClient.GetDefaultBinding(), ServiceColorClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IServiceColor.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceColorClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceColorClient.GetBindingForEndpoint(endpointConfiguration), ServiceColorClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceColorClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceColorClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceColorClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceColorClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceColorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public bool AgregarColor(ServiceColor.Color oColor)
        {
            return base.Channel.AgregarColor(oColor);
        }
        
        public System.Threading.Tasks.Task<bool> AgregarColorAsync(ServiceColor.Color oColor)
        {
            return base.Channel.AgregarColorAsync(oColor);
        }
        
        public bool ModificarColor(ServiceColor.Color oColor, int IdColor)
        {
            return base.Channel.ModificarColor(oColor, IdColor);
        }
        
        public System.Threading.Tasks.Task<bool> ModificarColorAsync(ServiceColor.Color oColor, int IdColor)
        {
            return base.Channel.ModificarColorAsync(oColor, IdColor);
        }
        
        public bool EliminarColor(int IdColor)
        {
            return base.Channel.EliminarColor(IdColor);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarColorAsync(int IdColor)
        {
            return base.Channel.EliminarColorAsync(IdColor);
        }
        
        public ServiceColor.DtoColor[] ListaColor()
        {
            return base.Channel.ListaColor();
        }
        
        public System.Threading.Tasks.Task<ServiceColor.DtoColor[]> ListaColorAsync()
        {
            return base.Channel.ListaColorAsync();
        }
        
        public ServiceColor.Color ObtenerColor(string Rubro)
        {
            return base.Channel.ObtenerColor(Rubro);
        }
        
        public System.Threading.Tasks.Task<ServiceColor.Color> ObtenerColorAsync(string Rubro)
        {
            return base.Channel.ObtenerColorAsync(Rubro);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceColor))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceColor))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:10524/ServiceColor.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceColorClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IServiceColor);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceColorClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IServiceColor);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IServiceColor,
        }
    }
}
