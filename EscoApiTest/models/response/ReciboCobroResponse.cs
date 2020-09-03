using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscoApiTest.models.response {
    class ReciboCobroResponse {
        /// <summary>
        /// Código interno de la Orden
        /// </summary>
        public long CodOperacion { get; set; }
        /// <summary>
        /// Número de orden, corresponde a los numeradores vigentes al momento del insert.
        /// </summary>
        public long NumOperacion { get; set; }
        //public decimal? Cantidad { get; set ; }
    }
}
