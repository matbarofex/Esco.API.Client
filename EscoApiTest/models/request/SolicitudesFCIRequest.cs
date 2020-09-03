using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscoApiTest.Settings;
using Newtonsoft.Json;

namespace EscoApiTest.models.request {
    class SolicitudesFCIRequest {
        /// <summary>
        /// Códigos de Comitente internos, separados por coma. 
        /// </summary>
        public string cuentas { get; set; }
        /// <summary>
        /// Fecha Inicial para la consulta de Solicitudes FCI.
        /// </summary>
        [JsonConverter(typeof(CustomJsonDateConverter))]
        public DateTime fechaDesde { get; set; }
        /// <summary>
        /// Fecha Final para la consulta de Solicitudes FCI.
        /// </summary>        
        [JsonConverter(typeof(CustomJsonDateConverter))]
        public DateTime fechaHasta { get; set; }
        /// <summary>
        /// Indica si los Boletos se buscan por Fecha de Concertación o no.
        /// </summary>
        public bool porConcertacion { get; set; }
        /// <summary>
        /// Indica si se muestran todas las cuentas del usuario consolidadas o solo la cuenta seleccionada.
        /// </summary>
        [DefaultValue(false)]
        public bool EsConsolidado { get; set; }
        /// <summary>
        /// Indica si se deben mostrar las Solicitudes FCI anuladas o no
        /// </summary>
        public bool mostrarCancelados { get; set; }
    }
}
