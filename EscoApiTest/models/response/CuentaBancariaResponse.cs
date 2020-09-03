using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.models.response {
    class CuentaBancariaResponse {
        /// <summary>
        /// Código interno de la Cuenta Bancaria.
        /// </summary>
        public long? CodCtaBancariaComitente { get; set; }
        /// <summary>
        /// Código interno de la Cuenta Comitente.
        /// </summary>
        public long? CodComitente { get; set; }
        /// <summary>
        /// Descripción del Banco.
        /// </summary>
        public string Banco { get; set; }
        /// <summary>
        /// Descripción del Tipo de Cuenta. Ej: Caja de Ahorro
        /// </summary>
        public string TipoCuentaBancaria { get; set; }
        /// <summary>
        /// Código interno de la Moneda.
        /// </summary>
        public long? CodMoneda { get; set; }
        /// <summary>
        /// Indicador de Cuenta Bancaria anulada.
        /// </summary>
        public bool EstaAnulada { get; set; }
        /// <summary>
        /// Descripcion de la Moneda.
        /// </summary>
        public string Moneda { get; set; }
        /// <summary>
        /// Codigo ISO de la Moneda.
        /// </summary>
        public string IDMoneda { get; set; }
        /// <summary>
        /// Número de Cuenta Bancaria.
        /// </summary>
        public string NumeroCuentaBancaria { get; set; }
        /// <summary>
        /// CBU de la Cuenta Bancaria.
        /// </summary>
        public string CBU { get; set; }
        /// <summary>
        /// CUIT vinculado con la Cuenta Bancaria.
        /// </summary>
        public string CUIT { get; set; }
    }
}
