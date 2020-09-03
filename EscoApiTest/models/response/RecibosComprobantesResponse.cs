using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscoApiTest.Settings;
using Newtonsoft.Json;

namespace EscoApiTest.models.response {
    class RecibosComprobantesResponse {
        /// <summary>
        /// Còdigo interno del movimiento.
        /// </summary>
        public long ID { get; set; }
        /// <summary>
        /// Código interno del comitente.
        /// </summary>
        public decimal? CodComitente { get; set; }
        /// <summary>
        /// Número de cuenta comitente.
        /// </summary>
        public long? NumComitente { get; set; }
        /// <summary>
        /// Código del tipo de movimiento.
        /// RC -> Recibo de Cobro
        /// CP -> Comprobante de Pago
        /// </summary>
        public string CodTpTesoreriaMov { get; set; }
        /// <summary>
        /// Descripción del tipo de movimiento.
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Fecha de concertación del movimiento.
        /// </summary>
        [JsonProperty("FechaConcertacion"), JsonConverter(typeof(CustomJsonDateTimeConverter))]
        public DateTime? FechaConcertacion { get; set; }
        /// <summary>
        /// Fecha de liquidación del movimiento.
        /// </summary>
        [JsonProperty("FechaLiquidacion"), JsonConverter(typeof(CustomJsonDateTimeConverter))]
        public DateTime? FechaLiquidacion { get; set; }
        /// <summary>
        /// Código de Moneda interno.
        /// </summary>
        public decimal CodMoneda { get; set; }
        /// <summary>
        /// Decripción de la moneda.
        /// </summary>
        public string Moneda { get; set; }
        /// <summary>
        /// Símbolo de la moneda.
        /// </summary>
        public string MonedaSimbolo { get; set; }
        /// <summary>
        /// Importe del movimiento.
        /// </summary>
        public decimal? Importe { get; set; }
        /// <summary>
        /// Cotización para convertir el importe a moneda local.
        /// </summary>
        public decimal? Cotizacion { get; set; }
        /// <summary>
        /// Importe en moneda local.
        /// </summary>
        public decimal? ImporteLocal { get; set; }
        /// <summary>
        /// Número de movimiento.
        /// </summary>
        public long? NumTesoreriaMov { get; set; }
        /// <summary>
        /// Gastos del movimiento.
        /// </summary>
        public decimal? Gastos { get; set; }
        /// <summary>
        /// Numero de referencia del movimiento.
        /// </summary>
        public string NumReferencia { get; set; }
        /// <summary>
        /// Comentario del movimiento.
        /// </summary>
        public string Comentario { get; set; }
    }
}
