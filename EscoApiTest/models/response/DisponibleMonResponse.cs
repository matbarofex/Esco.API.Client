using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.models.response {
    class DisponibleMonResponse {
        /// <summary>
        /// Descripción del saldo que se está mostrando.
        /// Ejemplo:  #DISPONIBLEPARAOPERAR  #POSICIONINICIAL #SUSCNOLIQUIDADAS 
        /// </summary>
        public string Detalle { get; set; }
        //public long CodMoneda { get ; set ; }
        /// <summary>
        /// Saldo del Item detallado.
        /// </summary>
        public decimal Importe { get; set; }
        /// <summary>
        /// Orden en que se muestran los items.
        /// </summary>
        public short Orden { get; set; }
        /// <summary>
        /// Símbolo de la Moneda del disponible.
        /// </summary>
        public string Simbolo { get; set; }
    }
}
