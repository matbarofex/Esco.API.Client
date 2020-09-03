using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscoApiTest.Settings;
using Newtonsoft.Json;

namespace EscoApiTest.models.request {
    class DisponibleMonRequest {
        /// <summary>
        /// Número de Cuenta Comitente.
        /// </summary>
        public long cuenta { get; set; }
        /// <summary>
        /// Fecha en que se pide la consulta.
        /// </summary>
        [JsonConverter(typeof(CustomJsonDateConverter))]
        public DateTime fechaDisponible { get; set; }
        /// <summary>
        /// Código ISO de la moneda.
        /// </summary>
        public string moneda { get; set; }
        /// <summary>
        /// Cantidad de días de antiguedad máximo para considerar Rescates pendientes de liquiación.
        /// </summary>
        public long diasRescatesPendientes { get; set; }
        /// <summary>
        /// Cantidad de días de antiguedad máximo para considerar Suscripciones pendientes de liquiación.
        /// </summary>
        public long diasSuscripcionesPendientes { get; set; }
        /// <summary>
        /// Plazo de liquidación del movimiento que se está cargando.
        /// Se suma al campo Fecha el plazo en días hábiles para calcular la fecha a la que se debe mostrar el disponible.
        /// </summary>
        public int plazo { get; set; }
        /// <summary>
        /// Indica si se deben considerar en el disponible los créditos para operar asignados en Back Office.
        /// </summary>
        public bool incluyeCreditos { get; set; }
        /// <summary>
        /// Se usa en licitaciones, es la fecha de liquidación del proceso de licitacón.
        /// Opcional
        /// </summary>
        //[JsonConverter(typeof(CustomJsonDateConverter))]
        public DateTime? fechaColocacionHasta { get; set; }
    }
}
