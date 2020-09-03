using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscoApiTest.Settings;
using Newtonsoft.Json;

namespace EscoApiTest.models.response {
    class SolicitudesFCIResponse {
        /// <summary>
        /// Código interno de solicitud.
        /// </summary>
        public long? CodSolicitudFdo { get; set; }
        /// <summary>
        /// Código interno del comitente.
        /// </summary>
        public long? CodComitente { get; set; }
        /// <summary>
        /// Número de cuenta comitente.
        /// </summary>
        public long? NumComitente { get; set; }
        /// <summary>
        /// Número de liquidación. (cuando la solicitud ya está liquidada)
        /// </summary>
        public long? NumLiquidacionFdoMov { get; set; }
        /// <summary>
        /// Número de Solicitud.
        /// </summary>
        public long? NumSolicitud { get; set; }
        /// <summary>
        /// Número de referencia. Depende de cada agente, puede ser un númro que relacione con un sistema externo.
        /// </summary>
        public long? NumReferencia { get; set; }
        /// <summary>
        /// Fecha de concertación de la solicitud.
        /// </summary>
        [JsonProperty("FechaConcertacion"), JsonConverter(typeof(CustomJsonDateTimeConverter))]
        public DateTime FechaConcertacion { get; set; }
        /// <summary>
        /// Fecha de liquidación de la solicitud.
        /// </summary>
        [JsonProperty("FechaLiquidacion"), JsonConverter(typeof(CustomJsonDateTimeConverter))]
        public DateTime? FechaLiquidacion { get; set; }
        /// <summary>
        /// Abreviatura del Fondo
        /// </summary>
        public string Fondo { get; set; }
        /// <summary>
        /// Aplica solo rescates. 
        /// Cuando el rescate es por cantidad, es la cantidad ingresada por el usuario.
        /// Cuando el rescate es por importe, es la cantidad calcula con el VCP de referencia.
        /// </summary>
        public decimal? Cantidad { get; set; }
        /// <summary>
        /// Es la descripción del tipo de operacion realizada.
        /// Los valores disponible sosn -> Suscripcion y Rescate.
        /// </summary>
        public string TpOperacion { get; set; }
        /// <summary>
        /// No aplica.
        /// </summary>
        public decimal? ValorCuotaparte { get; set; }
        /// <summary>
        /// Importe de la Suscripción o Rescate por importe.
        /// Los rescates por cantidad no informan este campo.
        /// </summary>
        public decimal? Importe { get; set; }
        /// <summary>
        /// Símbolo de la moneda de la solicitud.
        /// </summary>
        public string MonedaSimb { get; set; }
        /// <summary>
        /// Simbolo de la moneda del FCI.
        /// </summary>
        public string MonedaSimbFdo { get; set; }
        /// <summary>
        /// Indica la forma de pago de la operación. Las opciones posible son Moneda o Cuenta Bancaria.
        /// Cuando es moneda se informa -> Moneda
        /// Cuando es cuenta bancaria se informa -> "Cta. Bancaria" + Nombre del Banco + Moneda + Nro de Cuenta 
        /// </summary>
        public string FormaPago { get; set; }
        /// <summary>
        /// Indca Codigo del canal del ingreso de la solicitud actulmente las opciones son:
        /// "Home Banking"
        /// "Visual Bolsa"
        /// </summary>
        public string CodTpCanal { get; set; }
        /// <summary>
        /// Indca la descripcion del canal del ingreso de la solicitud actulmente las opciones son:
        /// "Home Banking"
        /// "Visual Bolsa"
        /// </summary>
        public string Canal { get; set; }
        /// <summary>
        /// Id de formulario WEB correspondiente.
        /// Para soliictudes de FCI es ->  "FRMSOLIFDOWEB"
        /// </summary>
        public string ClaveFormulario { get; set; }
        //public DateTime? HoraIngreso { get; set; }
        /// <summary>
        /// Código interno del FCI.
        /// </summary>
        public long? CodFondo { get; set; }
        /// <summary>
        /// Indica si la solicitud está anulada o no.
        /// </summary>
        public bool EstaAnulado { get; set; }
        /// <summary>
        /// Indica is la soliictud se ingreso fuera de perfil o no.
        /// </summary>
        public string FueraPerfil { get; set; }
        /// <summary>
        /// Codigo Bloomberg del FCI.
        /// </summary>
        public string CodInterfazBloomberg { get; set; }
        /// <summary>
        /// Codigo ISO de la Moneda del FCI.
        /// </summary>
        public string ISO { get; set; }
    }
}
