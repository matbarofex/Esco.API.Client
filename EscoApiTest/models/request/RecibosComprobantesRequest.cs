using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscoApiTest.Settings;
using Newtonsoft.Json;

namespace EscoApiTest.models.request {
    class RecibosComprobantesRequest {
        /// <summary>
        /// Números de Cuenta Comitente. Se usa cuando el parametro EsConsolidado es false.
        /// </summary>
        public string cuentas { get; set; }
        /// <summary>
        /// Fecha incial la para la consulta de Recibos y Comprobantes.
        /// </summary>
        [DefaultValue(false)]
        [JsonConverter(typeof(CustomJsonDateConverter))]
        public DateTime fechaDesde { get; set; }
        /// <summary>
        /// Fecha final la para la consulta de Recibos y Comprobantes.
        /// </summary>
        [JsonConverter(typeof(CustomJsonDateConverter))]
        public DateTime fechaHasta { get; set; }
        //public int TipoFecha { get ; set ; }
        /// <summary>
        /// Indica si los movimientos se buscarán por Fecha de Concertación o Fecha de Liquidación.
        /// </summary>
        public bool porConcertacion { get; set; }
        /// <summary>
        /// Indica si se muestran los movimientos de todas las cuentas del usuario autenticado o solo la cuenta seleccionada.
        /// </summary>
        public bool EsConsolidado { get; set; }
    }
}
