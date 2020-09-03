using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.models.request {
    class ReciboCobroRequest {
        /// <summary>
        /// Número de Comitente.
        /// </summary>
        public long Cuenta { get; set; }
        /// <summary>
        /// Código de ISO de la moneda el movimiento.
        /// </summary>
        public string Moneda { get; set; }
        /// <summary>
        /// Fecha de concertación del recibo de cobro.
        /// </summary>
        public DateTime FechaConcertacion { get; set; }
        /// <summary>
        /// Fecha de liquidación del recibo de cobro.
        /// </summary>
        public DateTime FechaLiquidacion { get; set; }
        /// <summary>
        /// Importe de movimiento expresado en la moneda indicada.
        /// Debe ser un valor mayor a cero.
        /// </summary>
        public decimal Importe { get; set; }
        /// <summary>
        /// Tipo de Cambio para convertir el importe del recibo a la moneda local.
        /// </summary>
        public decimal TpCambioMovPais { get; set; }
        /// <summary>
        /// Cuenta contable del agente donde se imputará el movimiento.
        /// Se debe ingresar el código interno de la cuenta contable.
        /// Los valores disponibles se pueden obtener con el método get-cuentas-bancarias-agente.
        /// </summary>
        public long CuentaContable { get; set; }
        /// <summary>
        /// Cuenta bancaria del cliente.
        /// Se debe ingresar el código interno.
        /// Es solo informativo, queda registrado solamente en el recibo de cobro.
        /// Los valores disponibles se pueden obtener con el método get-cuentas-bancarias-comitente.
        /// Es un dato opcional.
        /// </summary>
        public long CuentaBancariaComitente { get; set; }
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
