﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceRubroProducto
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoRubroProducto", Namespace="http://schemas.datacontract.org/2004/07/CapaServicioServidor")]
    public partial class DtoRubroProducto : object
    {
        
        private string CodigoRubroProductoField;
        
        private string DescripcionRubroProductoField;
        
        private System.DateTime FechaRegistroField;
        
        private int IdRubroProductoField;
        
        private double MargenGananciaField;
        
        private ServiceRubroProducto.Estado OEstadoField;
        
        private ServiceRubroProducto.Impuesto OImpuestoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoRubroProducto
        {
            get
            {
                return this.CodigoRubroProductoField;
            }
            set
            {
                this.CodigoRubroProductoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescripcionRubroProducto
        {
            get
            {
                return this.DescripcionRubroProductoField;
            }
            set
            {
                this.DescripcionRubroProductoField = value;
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
        public int IdRubroProducto
        {
            get
            {
                return this.IdRubroProductoField;
            }
            set
            {
                this.IdRubroProductoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MargenGanancia
        {
            get
            {
                return this.MargenGananciaField;
            }
            set
            {
                this.MargenGananciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceRubroProducto.Estado OEstado
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceRubroProducto.Impuesto OImpuesto
        {
            get
            {
                return this.OImpuestoField;
            }
            set
            {
                this.OImpuestoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Impuesto", Namespace="http://schemas.datacontract.org/2004/07/CapaNegocio")]
    public partial class Impuesto : object
    {
        
        private double AlicuotaField;
        
        private string DescripcionField;
        
        private System.DateTime FechaRegistroField;
        
        private int IdImpuestoField;
        
        private ServiceRubroProducto.Estado OEstadoField;
        
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
        public ServiceRubroProducto.Estado OEstado
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
        Inactivo = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Activo = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RubroProducto", Namespace="http://schemas.datacontract.org/2004/07/CapaNegocio")]
    public partial class RubroProducto : object
    {
        
        private string CodigoRubroProductoField;
        
        private string DescripcionRubroProductoField;
        
        private System.DateTime FechaRegistroField;
        
        private int IdRubroProductoField;
        
        private double MargenGananciaField;
        
        private ServiceRubroProducto.Estado OEstadoField;
        
        private ServiceRubroProducto.Impuesto OImpuestoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoRubroProducto
        {
            get
            {
                return this.CodigoRubroProductoField;
            }
            set
            {
                this.CodigoRubroProductoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescripcionRubroProducto
        {
            get
            {
                return this.DescripcionRubroProductoField;
            }
            set
            {
                this.DescripcionRubroProductoField = value;
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
        public int IdRubroProducto
        {
            get
            {
                return this.IdRubroProductoField;
            }
            set
            {
                this.IdRubroProductoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MargenGanancia
        {
            get
            {
                return this.MargenGananciaField;
            }
            set
            {
                this.MargenGananciaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceRubroProducto.Estado OEstado
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceRubroProducto.Impuesto OImpuesto
        {
            get
            {
                return this.OImpuestoField;
            }
            set
            {
                this.OImpuestoField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceRubroProducto.IServiceRubroProducto")]
    public interface IServiceRubroProducto
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/AgregarRubroProducto", ReplyAction="http://tempuri.org/IServiceRubroProducto/AgregarRubroProductoResponse")]
        bool AgregarRubroProducto(ServiceRubroProducto.DtoRubroProducto oRubroProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/AgregarRubroProducto", ReplyAction="http://tempuri.org/IServiceRubroProducto/AgregarRubroProductoResponse")]
        System.Threading.Tasks.Task<bool> AgregarRubroProductoAsync(ServiceRubroProducto.DtoRubroProducto oRubroProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/ModificarRubroProducto", ReplyAction="http://tempuri.org/IServiceRubroProducto/ModificarRubroProductoResponse")]
        bool ModificarRubroProducto(ServiceRubroProducto.DtoRubroProducto oRubroProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/ModificarRubroProducto", ReplyAction="http://tempuri.org/IServiceRubroProducto/ModificarRubroProductoResponse")]
        System.Threading.Tasks.Task<bool> ModificarRubroProductoAsync(ServiceRubroProducto.DtoRubroProducto oRubroProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/EliminarRubroProducto", ReplyAction="http://tempuri.org/IServiceRubroProducto/EliminarRubroProductoResponse")]
        bool EliminarRubroProducto(int IdRubroProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/EliminarRubroProducto", ReplyAction="http://tempuri.org/IServiceRubroProducto/EliminarRubroProductoResponse")]
        System.Threading.Tasks.Task<bool> EliminarRubroProductoAsync(int IdRubroProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/ListaRubroProducto", ReplyAction="http://tempuri.org/IServiceRubroProducto/ListaRubroProductoResponse")]
        ServiceRubroProducto.DtoRubroProducto[] ListaRubroProducto();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/ListaRubroProducto", ReplyAction="http://tempuri.org/IServiceRubroProducto/ListaRubroProductoResponse")]
        System.Threading.Tasks.Task<ServiceRubroProducto.DtoRubroProducto[]> ListaRubroProductoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/ObtenerRubroProductoByDescripcion", ReplyAction="http://tempuri.org/IServiceRubroProducto/ObtenerRubroProductoByDescripcionRespons" +
            "e")]
        ServiceRubroProducto.RubroProducto ObtenerRubroProductoByDescripcion(string oRubroProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/ObtenerRubroProductoByDescripcion", ReplyAction="http://tempuri.org/IServiceRubroProducto/ObtenerRubroProductoByDescripcionRespons" +
            "e")]
        System.Threading.Tasks.Task<ServiceRubroProducto.RubroProducto> ObtenerRubroProductoByDescripcionAsync(string oRubroProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/ObtenerRubroProductoById", ReplyAction="http://tempuri.org/IServiceRubroProducto/ObtenerRubroProductoByIdResponse")]
        ServiceRubroProducto.RubroProducto ObtenerRubroProductoById(int oRubroProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/ObtenerRubroProductoById", ReplyAction="http://tempuri.org/IServiceRubroProducto/ObtenerRubroProductoByIdResponse")]
        System.Threading.Tasks.Task<ServiceRubroProducto.RubroProducto> ObtenerRubroProductoByIdAsync(int oRubroProducto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/ObtenerEstadoByDescripcion", ReplyAction="http://tempuri.org/IServiceRubroProducto/ObtenerEstadoByDescripcionResponse")]
        ServiceRubroProducto.Estado ObtenerEstadoByDescripcion(string oEstado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/ObtenerEstadoByDescripcion", ReplyAction="http://tempuri.org/IServiceRubroProducto/ObtenerEstadoByDescripcionResponse")]
        System.Threading.Tasks.Task<ServiceRubroProducto.Estado> ObtenerEstadoByDescripcionAsync(string oEstado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/ObtenerImpuestoByDescripcion", ReplyAction="http://tempuri.org/IServiceRubroProducto/ObtenerImpuestoByDescripcionResponse")]
        ServiceRubroProducto.Impuesto ObtenerImpuestoByDescripcion(string oImpuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/ObtenerImpuestoByDescripcion", ReplyAction="http://tempuri.org/IServiceRubroProducto/ObtenerImpuestoByDescripcionResponse")]
        System.Threading.Tasks.Task<ServiceRubroProducto.Impuesto> ObtenerImpuestoByDescripcionAsync(string oImpuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/ObtenerImpuestoById", ReplyAction="http://tempuri.org/IServiceRubroProducto/ObtenerImpuestoByIdResponse")]
        ServiceRubroProducto.Impuesto ObtenerImpuestoById(int oImpuesto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRubroProducto/ObtenerImpuestoById", ReplyAction="http://tempuri.org/IServiceRubroProducto/ObtenerImpuestoByIdResponse")]
        System.Threading.Tasks.Task<ServiceRubroProducto.Impuesto> ObtenerImpuestoByIdAsync(int oImpuesto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IServiceRubroProductoChannel : ServiceRubroProducto.IServiceRubroProducto, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class ServiceRubroProductoClient : System.ServiceModel.ClientBase<ServiceRubroProducto.IServiceRubroProducto>, ServiceRubroProducto.IServiceRubroProducto
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServiceRubroProductoClient() : 
                base(ServiceRubroProductoClient.GetDefaultBinding(), ServiceRubroProductoClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IServiceRubroProducto.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceRubroProductoClient(EndpointConfiguration endpointConfiguration) : 
                base(ServiceRubroProductoClient.GetBindingForEndpoint(endpointConfiguration), ServiceRubroProductoClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceRubroProductoClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServiceRubroProductoClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceRubroProductoClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServiceRubroProductoClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServiceRubroProductoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public bool AgregarRubroProducto(ServiceRubroProducto.DtoRubroProducto oRubroProducto)
        {
            return base.Channel.AgregarRubroProducto(oRubroProducto);
        }
        
        public System.Threading.Tasks.Task<bool> AgregarRubroProductoAsync(ServiceRubroProducto.DtoRubroProducto oRubroProducto)
        {
            return base.Channel.AgregarRubroProductoAsync(oRubroProducto);
        }
        
        public bool ModificarRubroProducto(ServiceRubroProducto.DtoRubroProducto oRubroProducto)
        {
            return base.Channel.ModificarRubroProducto(oRubroProducto);
        }
        
        public System.Threading.Tasks.Task<bool> ModificarRubroProductoAsync(ServiceRubroProducto.DtoRubroProducto oRubroProducto)
        {
            return base.Channel.ModificarRubroProductoAsync(oRubroProducto);
        }
        
        public bool EliminarRubroProducto(int IdRubroProducto)
        {
            return base.Channel.EliminarRubroProducto(IdRubroProducto);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarRubroProductoAsync(int IdRubroProducto)
        {
            return base.Channel.EliminarRubroProductoAsync(IdRubroProducto);
        }
        
        public ServiceRubroProducto.DtoRubroProducto[] ListaRubroProducto()
        {
            return base.Channel.ListaRubroProducto();
        }
        
        public System.Threading.Tasks.Task<ServiceRubroProducto.DtoRubroProducto[]> ListaRubroProductoAsync()
        {
            return base.Channel.ListaRubroProductoAsync();
        }
        
        public ServiceRubroProducto.RubroProducto ObtenerRubroProductoByDescripcion(string oRubroProducto)
        {
            return base.Channel.ObtenerRubroProductoByDescripcion(oRubroProducto);
        }
        
        public System.Threading.Tasks.Task<ServiceRubroProducto.RubroProducto> ObtenerRubroProductoByDescripcionAsync(string oRubroProducto)
        {
            return base.Channel.ObtenerRubroProductoByDescripcionAsync(oRubroProducto);
        }
        
        public ServiceRubroProducto.RubroProducto ObtenerRubroProductoById(int oRubroProducto)
        {
            return base.Channel.ObtenerRubroProductoById(oRubroProducto);
        }
        
        public System.Threading.Tasks.Task<ServiceRubroProducto.RubroProducto> ObtenerRubroProductoByIdAsync(int oRubroProducto)
        {
            return base.Channel.ObtenerRubroProductoByIdAsync(oRubroProducto);
        }
        
        public ServiceRubroProducto.Estado ObtenerEstadoByDescripcion(string oEstado)
        {
            return base.Channel.ObtenerEstadoByDescripcion(oEstado);
        }
        
        public System.Threading.Tasks.Task<ServiceRubroProducto.Estado> ObtenerEstadoByDescripcionAsync(string oEstado)
        {
            return base.Channel.ObtenerEstadoByDescripcionAsync(oEstado);
        }
        
        public ServiceRubroProducto.Impuesto ObtenerImpuestoByDescripcion(string oImpuesto)
        {
            return base.Channel.ObtenerImpuestoByDescripcion(oImpuesto);
        }
        
        public System.Threading.Tasks.Task<ServiceRubroProducto.Impuesto> ObtenerImpuestoByDescripcionAsync(string oImpuesto)
        {
            return base.Channel.ObtenerImpuestoByDescripcionAsync(oImpuesto);
        }
        
        public ServiceRubroProducto.Impuesto ObtenerImpuestoById(int oImpuesto)
        {
            return base.Channel.ObtenerImpuestoById(oImpuesto);
        }
        
        public System.Threading.Tasks.Task<ServiceRubroProducto.Impuesto> ObtenerImpuestoByIdAsync(int oImpuesto)
        {
            return base.Channel.ObtenerImpuestoByIdAsync(oImpuesto);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceRubroProducto))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServiceRubroProducto))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:10524/ServiceRubroProducto.svc");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServiceRubroProductoClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IServiceRubroProducto);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServiceRubroProductoClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IServiceRubroProducto);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IServiceRubroProducto,
        }
    }
}
